﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using trifenix.connect.mdm.entity_model;
using trifenix.connect.mdm.enums;
using trifenix.connect.mdm_attributes;
using trifenix.connect.search_mdl;

namespace trifenix.connect.util
{




    /// <summary>
    /// Todos los métodos relacionados con la obtención de metadata y valores desde el modelo de clases y la conversión de esta 
    /// al modelo de metada de trifenix y viceversa.
    /// </summary>
    public static partial class Mdm
    {

        /// <summary>
        /// Retorna un objeto desde un entitySearch, el tipo del objeto de retorno será del tipo que utilice el atributo EntityIndexAttribute .
        /// para esto buscará todas las clases que tnengan el atributo EntityIndexAttribute que vincula la clase con el índice
        /// del entitySearch, una vez encontrada hará lo mismo con los atributos de cada propiedad para finalmente crear un objeto tipado con todos los valores del entitySearch.
        /// </summary>
        /// <typeparam name="T">Las entidades tienen un tipo de dato geo, que depende de la base de datos a usar.</typeparam>        
        /// <param name="entitySearch">entitySearch a convertir</param>
        /// <param name="anyElementInAssembly">assembly donde buscar la clase que sea del tipo de la entidad</param>
        /// <param name="nms">namespace donde se encuentra la clase que sea del tipo de entidad</param>
        /// <returns>objeto de una clase que representa una entidad</returns>
        public static object GetEntityFromSearch<T>(IEntitySearch<T> entitySearch, Type anyElementInAssembly, string nms, Func<T, object> geoConvert, ISearchEntity<T> sEntity)
        {
            
            // obtiene el tipo de clase de acuerdo al índice de la entidad.
            var type = Reflection.GetEntityType(entitySearch.index, anyElementInAssembly, nms);


            // crea una nueva instancia del tipo determinado por la entidad
            // por ejemplo, si el indice de entidad correspondiera a 1 que es Persona, esta sería la clase persona.
            var entity = Reflection.Collections.CreateEntityInstance(type);


            // asigna el id del objeto convertido
            // todas los elementos de la base de datos tienn la propiedad id.
            type.GetProperty("Id")?.SetValue(entity, entitySearch.id);


            // busca todas las propiedades que tengan el atributo baseIndexAttribute que identifica la metadata donde reside el índice y el tipo de dato.
            var props = entity.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(BaseIndexAttribute), true)).ToList();


           
            // recorre las propiedades de una clase y le asigna los valores correspondientes a las propiedades del entitySearch
            props.ForEach(prop => {

                // obtiene el atributo y su metadata
                var attr = prop.GetCustomAttribute<BaseIndexAttribute>(true);

                // con la metadata de la propiedad (índice, tipo de dato y si es o no entidad, obtiene el valor o la colección de valores de una propiedad.
                var values = Reflection.Collections.FormatValues(prop, GetValues<T>(entitySearch, attr.IsEntity, attr.KindIndex, attr.Index, geoConvert, sEntity, anyElementInAssembly, nms ));

                // asigna el valor a la clase. 
                prop.SetValue(entity, values);
            });

            // retorna un objeto tipado desde un entitySearch.
            return entity;
        }


        /// <summary>
        /// Obtiene la propiedad o contenedor con el índice de una entidad y su identificador (index = 1, id = [guid]), donde el 1 representa una entidad.
        /// el método genera una nueva propiedad del tipo que se le asigne en el atributo typeToCast.
        /// este tipo debe implementar IRelatedId.
        /// retorna solo aquellas que tienen su propio documento en la base de datos.
        /// </summary>
        /// <param name="attribute">atributo con la metadata de la propiedad</param>
        /// <param name="typeToCast">tipo de dato a convertir, debe implementar IRelatedId</param>
        /// <returns>nueva propiedad de tipo entidad desde un objeto.</returns>
        public static IRelatedId[] GetRelatedId(KeyValuePair<BaseIndexAttribute, object> attribute, Type typeToCast)
        {
            // lanza error si no implementa IRelatedId
            if (!CheckImplementsIRelatedId(typeToCast))
            {
                throw new Exception("Debe implementar IRelatedId");
            }

            // retorna la propiedad de tipo IRelatedId si el atributo es de tip entidad y de tipo referencia (clase con su propio documento en db documental).
            if (attribute.Key.IsEntity && attribute.Key.KindIndex == (int)KindEntityProperty.REFERENCE)
            {
                // retorna una propiedad de tipo entidad de referencia
                return GetEntityProperty(attribute.Key.Index, (string)attribute.Value, typeToCast);
            }

            // retorna nulo si no encuentra.
            return null;
        }


        /// <summary>
        /// Retorna el valor de una propiedad de un objeto, desde un entitySearch indicando cual es la propiedad.
        /// </summary>
        /// <see cref="KindProperty">Tipo de propiedad de valor</see>
        /// <see cref="KindEntityProperty">Tipo de propiedad de referencia</see>
        /// <typeparam name="T">Tipo de valor a entregar</typeparam>
        /// <param name="entitySearch">Entidad a convertir</param>
        /// <param name="isEntity">Determina si la propiedad que se desea obtener es de tipo entidad o es una propiedad primitiva (DateTime, número, etc.)</param>
        /// <param name="typeRelated">identificador del tipo de valor a obtener, para el caso de las propiedades sería KindProperty y para entidades KindEntityProperty</param>
        /// <param name="indexProperty">índice de la propiedad</param>
        /// <param name="geoConvert">convierte el tipo geo del entitySearch a el objeto de la instancia de la clase a obtener</param>
        /// <param name="anyElementInAssembly">Tipo de un objeto que se encuentre en el assembly donde está la clase con la metadata</param>
        /// <param name="nms">namespace donde se encuentra la clase con la metadata</param>
        /// <param name="sEntity">Interface para obtener un entitySearch desde una clase local</param>
        /// <returns>valor de una propiedad</returns>
        public static List<object> GetValues<T>(IEntitySearch<T> entitySearch, bool isEntity, int typeRelated, int indexProperty, Func<T, object> geoConvert, ISearchEntity<T> sEntity = null,Type anyElementInAssembly = null, string nms = null)
        {

            // se la propiedad corresponde a una entidad referencial local, debe tener los argumentos para obtener la entidad desde el repositorio.
            if ((sEntity == null || anyElementInAssembly == null || string.IsNullOrWhiteSpace(nms)) && isEntity)
            {
                throw new Exception("si el tipo a recuperar es de tipo entidad ");
            }

            // retorno si es nulo.
            List<object> values = new List<object>();


            // si es entidad
            if (isEntity)
            {
                // castea el tipo al tipo de entidad.
                var relatedEntity = (KindEntityProperty)typeRelated;


                switch (relatedEntity)
                {

                    // si es referencia retornará la colección de ids del tipo de entidad solicitada.
                    case KindEntityProperty.REFERENCE:
                        return (List<object>)entitySearch.rel?.Where(relatedId => relatedId.index == indexProperty).Select(s => s.id).Cast<object>().ToList() ?? values;

                    // al ser local, debe ir a buscar el objeto al repositorio del search y convertirlo en el objeto que indica la metadata de la propidad
                    case KindEntityProperty.LOCAL_REFERENCE:
                        return entitySearch.rel?.ToList().FindAll(relatedId => relatedId.index == indexProperty).Select(relatedId => GetEntityFromSearch(sEntity.GetEntity(indexProperty, relatedId.id), anyElementInAssembly, nms, geoConvert, sEntity)).ToList() ?? values;
                    default:
                        return null;
                }

            }

            // si es de tipo propidad de valor. castea a enumeración.
            var props = (KindProperty)typeRelated;

            // retorna el valor o colección de valores desde una propiedad.
            switch (props)
            {
                case KindProperty.STR:
                    return GetPropValues(entitySearch.str, indexProperty).Cast<object>().ToList();
                case KindProperty.SUGGESTION:
                    return GetPropValues(entitySearch.sug, indexProperty).Cast<object>().ToList();
                case KindProperty.NUM64:
                    return GetPropValues(entitySearch.num64, indexProperty).Cast<object>().ToList();
                case KindProperty.NUM32:
                    return GetPropValues(entitySearch.num32, indexProperty).Cast<object>().ToList();
                case KindProperty.DBL:
                    return GetPropValues(entitySearch.dbl, indexProperty).Cast<object>().ToList();
                case KindProperty.BOOL:
                    return GetPropValues(entitySearch.bl, indexProperty).Cast<object>().ToList();
                case KindProperty.GEO:
                    return GetPropValues(entitySearch.geo, indexProperty).Cast<T>().Select(geoConvert).ToList();
                case KindProperty.ENUM:
                    return GetPropValues(entitySearch.enm, indexProperty).Cast<object>().ToList();
                case KindProperty.DATE:
                    return GetPropValues(entitySearch.dt, indexProperty).Cast<object>().ToList();
                default:
                    return null;
            }
        }


        /// <summary>
        /// retorna los valores desde una colección de propiedades.
        /// </summary>
        /// <typeparam name="T">Tipo de valor de la propiedad</typeparam>
        /// <param name="props">propiedades que serán usadas para retornar los valores</param>
        /// <param name="index">índice de la propiedad</param>
        /// <returns></returns>
        public static T[] GetPropValues<T>(IProperty<T>[] props, int index) => props.Where(s => s.index == index).Select(s => s.value).ToArray();




        /// <summary>
        /// Verifica si un tipo es una propiedad (IProperty<>)
        /// </summary>
        /// <see cref="IProperty{T}"/>
        /// <param name="typeToCheck">tipo a verificar</param>
        /// <returns>true, si implementa IProperty</returns>
        public static bool CheckImplementsIProperty(Type typeToCheck) {
            return typeToCheck.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IProperty<>));
        }

        /// <summary>
        /// Verifica si un tipo es una propiedad de tipo entidad (IRelatedId)
        /// </summary>
        /// <see cref="IRelatedId"/>
        /// <param name="typeToCheck">tipo a verificar</param>
        /// <returns>true, si implementa IRelatedId</returns>
        public static bool CheckImplementsIRelatedId(Type typeToCheck)
        {
            var isRelated = typeof(IRelatedId).IsAssignableFrom(typeToCheck);
            return isRelated;
        }


        /// <summary>
        /// Una propiedad de un entitySearch es un contenedor con un índice que mapea una propiedad de una clase y el valor que tiene esa propiedad ,
        /// de acuerdo al tipo de propiedad de la clase será el tipo de contenedor que retornará.        
        /// </summary>
        /// <typeparam name="T">Tipo de propiedad (string, double, enum, etc.)</typeparam>        
        /// <see cref="IEntitySearch{T}" />
        /// <see cref="IProperty{T}"/>
        /// <param name="index">índice para la propiedad</param>
        /// <param name="value">valor que se asignará a la propiedad</param>
        /// <param name="typeToCast">Tipo de la nueva propiedad a retornar</param>
        /// <param name="castToGeo">Para el caso de tipo geo, normalmente el valor geo en el modelo de clases puede ser distinto al de geo del search. para ese caso usará esta función, para convertir desde el geo del modelo de clases, al del de busqueda (Implementación de IEntitySearch<T>)</param>
        /// <returns>propiedad de un entitySearch con su índice y valor</returns>
        public static IProperty<T> GetProperty<T>(int index, object value, Type typeToCast, Func<object, T> castToGeo = null)
        {
            if (!CheckImplementsIProperty(typeToCast))
            {
                throw new Exception("El tipo debe implementar IProperty");
            }

            // crea una nueva instancia de una propiedad (entrada de un entity search).
            var element = (IProperty<T>)Reflection.Collections.CreateEntityInstance(typeToCast);

            // asigna el índice
            element.index = index;

            // Castea el valor al tipo que se indica. si es geo usará la función externa.
            try
            {   
                element.value = castToGeo ==null?(T)value:castToGeo(value);
            }
            catch (Exception e)
            {
                // TODO: revisar forma más elegante.
                if (e.Message.Equals("Unable to cast object of type 'System.Int32' to type 'System.Int64'."))
                    element.value = (T)(object)Convert.ToInt64(value);
                else
                    throw;
            }
            return element;
        }


        /// <summary>
        /// Un EntitySearch se compone de propiedades que relacionan otros EntitySearch
        /// estas propiedades tienen el índice que identifica el tipo de entidad (Persona, Producto o cualquier tipo de agrupación) y el id que identifica un elemento dentro de una base de datos.
        /// este método crea una propiedad de este tipo
        /// </summary>
        /// <param name="index">índice del tipo de entidad</param>
        /// <param name="value">identificador de la entidad</param>
        /// <param name="typeToCast">Tipo al que debe ser convertido (debe implementar IRelatedId)</param>
        /// <returns></returns>
        public static IRelatedId[] GetEntityProperty(int index, object value, Type typeToCast) {


            // verifica si implementa IRelatedId
            if (!CheckImplementsIRelatedId(typeToCast))
            {
                throw new Exception("El tipo debe implementar IRelatedId");
            }

            // crea una nueva instancia de una propiedad (entrada de un entity search).
            var element = (IRelatedId)Reflection.Collections.CreateEntityInstance(typeToCast);
            var isEnumerable = Reflection.IsEnumerable(value);

            if (isEnumerable)
            {
                return ((IEnumerable<string>)value).Select(s =>
                {
                    var lcl = (IRelatedId)Reflection.Collections.CreateEntityInstance(typeToCast);
                    lcl.index = index;
                    lcl.id = s;
                    return lcl;
                }).ToArray();
            }
           

            // asigna el índice
            element.index = index;
            element.id = (string)value;
            return new IRelatedId[] { element};
        }


        
        /// <summary>
        /// Obtiene un array de propiedades de acuerdo al índice y tipo de dato que tenga la metadata del atributo
        /// </summary>
        /// <typeparam name="T">Tipo de valor de la propiedad que será retornada</typeparam>
        /// <param name="attribute">tupla con el atributo de la propiedad y el valor de la instancia</param>
        /// <param name="typeToCast">Tipo de dato a convertir</param>
        /// <returns></returns>
        public static IEnumerable<IProperty<T>> GetArrayOfElements<T>(KeyValuePair<BaseIndexAttribute, object> attribute, Type typeToCast, Func<object, T> castGeoToSearch = null)
        {
            // comprueba si es una colección
            if (Reflection.IsEnumerable(attribute.Value))
            {
                // si es una colección retornara una propiedad por cada item de la colección.
                return ((IEnumerable<T>)attribute.Value).Select(s => GetProperty<T>(attribute.Key.Index, s, typeToCast));
            }
            else {
                // si no es una colección, envía una lista con una sola propiedad.
                return new List<IProperty<T>> { GetProperty<T>(attribute.Key.Index, attribute.Value, typeToCast, castGeoToSearch) };
            }
        }


     
        /// <summary>
        /// Obtiene todas las propiedades del tipo que se le indique para un objeto
        /// estos tipos son de valor (str,num32, enum, geo, etc.)
        /// Desde esta se especializan otro métodos
        /// las propiedades conformar un entitySearch, base del modelo MDM.
        /// </summary>
        /// <typeparam name="T">Tipo de valor la propiedad</typeparam>
        /// <param name="related">Tipo de propiedad</param>
        /// <param name="elements">metadata y datos de un objeto</param>
        /// <param name="castGeoToSearch">Función para convertir el elemento geo de la clase a la de la entidad de busqueda</param>
        /// <returns>listado de propiedades de un tipo</returns>
        public static IEnumerable<T2_Cast> GetPropertiesObjects<T,T2_Cast>(KindProperty related, Dictionary<BaseIndexAttribute, object> elements, Func<object, T> castGeoToSearch = null) where T2_Cast : IProperty<T> {
            var array = elements.Where(s => !s.Key.IsEntity && s.Key.KindIndex == (int)related).SelectMany(s => GetArrayOfElements<T>(s, typeof(T2_Cast), castGeoToSearch)).ToList();
            return !array.Any() ? Array.Empty<T2_Cast>() : (IEnumerable<T2_Cast>)array.Cast<T2_Cast>();
        }

        /// <summary>
        /// Obtiene referencias de una entidad (no locales), desde el listado de metadata y valores de un objeto.
        /// si encuentra atributos de tipo related, ontendrá el índice y el valor para formar una propiedad de tipo IRelatedId
        /// </summary>
        /// <param name="elements">Diccionario con la metadata y valor de la propiedad</param>
        /// <param name="typeToCast">Tipo a convertir que implemente IRelatedId</param>
        /// <returns>array de clase indicada que implementa IRelatdId</returns>
        public static IRelatedId[] GetReferences(Dictionary<BaseIndexAttribute, object> elements, Type typeToCast) {

            try
            {
                /*
                 * var array = elements.Where(s => !s.Key.IsEntity && s.Key.KindIndex == (int)related).SelectMany(s => GetArrayOfElements<T>(s, typeof(T2_Cast), castGeoToSearch)).ToList();
                    return !array.Any() ? Array.Empty<T2_Cast>() : (IEnumerable<T2_Cast>)array.Cast<T2_Cast>();
                 */
                var array = elements.Where(s => s.Key.IsEntity && s.Key.KindIndex == (int)KindEntityProperty.REFERENCE);

                var refes = array.SelectMany(s => GetEntityProperty(s.Key.Index, s.Value, typeToCast)).ToArray();
                return !refes.Any() ? Array.Empty<IRelatedId>() : refes;

            }
            catch (Exception e)
            {

                throw;
            }
        
        }
            


        /// <summary>
        /// Obtiene las propiedades de tipo double encontradas en un objeto
        /// Obtiene las propiedades de tipo entero 
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>array de clase indicada que implementa INum32Property</returns>
        public static INum32Property[] GetNumProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, INum32Property =>
            GetPropertiesObjects<int, T>(KindProperty.NUM32, values).ToArray();
            
        /// <summary>
        /// Obtiene las propiedades de tipo double encontradas en un objeto
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>array de clase indicada que implementa IDblProperty</returns>
        public static IDblProperty[] GetDblProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IDblProperty =>
            GetPropertiesObjects<double, T>(KindProperty.DBL, values).ToArray();


        /// <summary>
        /// Obtiene las propiedades de tipo fecha encontradas en un objeto
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>array de clase indicada que implementa IDtProperty</returns>
        public static IDtProperty[] GetDtProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IDtProperty =>
            GetPropertiesObjects<DateTime, T>(KindProperty.DATE, values).ToArray();


        /// <summary>
        /// Obtiene las propiedades de tipo enum encontradas en un objeto.
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>array de clase indicada que implementa IEnumProperty</returns>
        public static IEnumProperty[] GetEnumProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IEnumProperty =>
            GetPropertiesObjects<int, T>(KindProperty.ENUM, values).ToArray();


        /// <summary>
        /// Obtiene las propiedades de tipo entero
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>array de clase indicada que implementa IBoolProperty</returns>
        public static IBoolProperty[] GetBoolProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IBoolProperty =>
            GetPropertiesObjects<bool, T>(KindProperty.BOOL, values).ToArray();


        /// <summary>
        /// Obtiene las propiedades de tipo geo base de un entitySearch encontradas en un objeto.
        /// el caso de geo, depende de la base de datos, ya que cada db puede tener un formato distinto para el tipo geo.
        /// por eso, este método incorpora un método de entrada, para convertir un tipo geo de la clase del objeto al que corresponda de la base de datos
        /// que usa un entitySearch
        /// </summary>
        /// <typeparam name="T">Tipo de dato de la propiedad geo de una entidad</typeparam>
        /// <param name="castGeoToSearch">Convierte el objeto geo de una instancia de una clase al entitySearch.</param>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad.</param>
        /// <returns>retorna un array de clase indicada que implementa IBoolProperty</returns>
        public static IProperty<T>[] GetGeoProps<T, T2>(Dictionary<BaseIndexAttribute, object> values, Func<object, T> castGeoToSearch) where T2 : class, IProperty<T> =>
            GetPropertiesObjects<T, T2>(KindProperty.GEO, values, castGeoToSearch).ToArray();


        /// <summary>
        /// Obtiene las propiedades de tipo long encontradas en un objeto
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>   
        /// <returns>retorna una array de propiedades de tipo  long que implemente INum64Property</returns>
        public static INum64Property[] GetNum64Props<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, INum64Property =>
            GetPropertiesObjects<long, T>(KindProperty.NUM64, values).ToArray();



        /// <summary>
        /// Obtiene las propiedades de tipo string encontradas en un objeto
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>retorna una array de propiedades de tipo string que implemente IStrProperty</returns>
        public static IStrProperty[] GetStrProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IStrProperty =>
          GetPropertiesObjects<string, T>(KindProperty.STR, values).ToArray();



        /// <summary>
        /// Obtiene las propiedades de tipo string encontradas en un objeto, pero que indiquen que la propiedad es de tipo suggest.
        /// las propiedades de tipo suggest indican que tendrán mayor indexación.
        /// base del entitySearch
        /// </summary>
        /// <param name="values">Diccionario con la metadata y valor de la propiedad</param>
        /// <returns>retorna una array de propiedades de tipo string que implemente IStrProperty, de propiedades que consideren suggest en su atributo mdm</returns>
        public static IStrProperty[] GetSugProps<T>(Dictionary<BaseIndexAttribute, object> values) where T : class, IStrProperty =>
          GetPropertiesObjects<string, T>(KindProperty.SUGGESTION, values).ToArray();



        /// <summary>
        /// obtiene una nueva entidad con sus propiedaes, sin asignar el id y sin referencias locales.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de la propiedad geo de una entidad</typeparam>
        /// <see cref="Implements{T}"/>
        /// <param name="implements">objeto que mantiene todos los tipos a los que cada propiedad debe ser convertido</param>
        /// <param name="obj">objeto desde el que se obtendrán los atributos</param>
        /// <param name="typeToCast">tipo al que será convertido la nueva entidad</param>
        /// <param name="index">índice de la entidad a crear, el índice se encuentra en el atributo mdm de la clase</param>
        /// <returns>retorna un nuevo entitySearch desde un objeto, instancia de una clase.</returns>
        public static IEntitySearch<T> GetSimpleEntity<T>(Implements<T> implements, object obj, Type typeToCast, int index) {

            // obtiene la metadata y los datos del objeto
            var mdl = Reflection.Attributes.GetPropertiesByAttributeWithValue(obj);

            // asigna las propiedades.
            var entitySearch = FillProps(implements, mdl, typeToCast);

            // toma el índice de la metadata del atributo
            entitySearch.index = index;
            // asigna una fecha de creación. chequear si es necesario
            entitySearch.created = DateTime.Now;

            // retorna un entitySearch.
            return entitySearch;
        }

        /// <summary>
        /// entrega un nuevo entitySearch sin considerar las referencias locales y sin asignarle un id.
        /// </summary>
        /// <typeparam name="T">Tipo de dato de la propiedad geo de una entidad </typeparam>
        /// <param name="implements">objeto que mantiene todos los tipos a los que cada propiedad debe ser convertido</param>
        /// <param name="typeToCast">tipo a convertir el entity, debe implementar IEntitySearch<T></param>
        /// <param name="mdl">diccionario con la metadata y los datos de cada propiedad.</param>
        /// <returns>nueva entidad desde ub objeto</returns>
        public static IEntitySearch<T> FillProps<T>(Implements<T> implements, Dictionary<BaseIndexAttribute, object> mdl, Type typeToCast) {
            var objSearch = Reflection.Collections.CreateEntityInstance(typeToCast);
            var entitySearch = GetEntityBaseSearch<T>(objSearch);

            entitySearch.num32 = (INum32Property[])Reflection.InvokeDynamicGeneric("GetNumProps", implements.num32, new object[] { mdl });
            entitySearch.dbl = (IDblProperty[])Reflection.InvokeDynamicGeneric("GetDblProps", implements.dbl, new object[] { mdl });
            entitySearch.dt = (IDtProperty[])Reflection.InvokeDynamicGeneric("GetDtProps", implements.dt, new object[] { mdl });
            entitySearch.enm = (IEnumProperty[])Reflection.InvokeDynamicGeneric("GetEnumProps", implements.enm, new object[] { mdl });
            entitySearch.bl = (IBoolProperty[])Reflection.InvokeDynamicGeneric("GetBoolProps", implements.bl, new object[] { mdl });
            entitySearch.geo = (IProperty<T>[])Reflection.InvokeDynamicGeneric("GetGeoProps", implements.geo, new object[] { mdl, implements.GeoObjetoToGeoSearch }, typeof(T));
            entitySearch.num64 = (INum64Property[])Reflection.InvokeDynamicGeneric("GetNum64Props", implements.num64, new object[] { mdl });
            entitySearch.str = (IStrProperty[])Reflection.InvokeDynamicGeneric("GetStrProps", implements.str, new object[] { mdl });
            entitySearch.sug = (IStrProperty[])Reflection.InvokeDynamicGeneric("GetSugProps", implements.sug, new object[] { mdl });
            entitySearch.rel = GetReferences(mdl, implements.rel);
            return entitySearch;
        }

        public static EntityBaseSearch<T> GetEntityBaseSearch<T>(object entity) {
            var entitySearch = new EntityBaseSearch<T>();

            entitySearch.num32 = (INum32Property[])entity.GetType().GetProperty("num32").GetValue(entity);

            entitySearch.dbl = (IDblProperty[])entity.GetType().GetProperty("dbl").GetValue(entity);
            entitySearch.dt = (IDtProperty[])entity.GetType().GetProperty("dt").GetValue(entity);
            entitySearch.enm = (IEnumProperty[])entity.GetType().GetProperty("enm").GetValue(entity); 
            entitySearch.bl = (IBoolProperty[])entity.GetType().GetProperty("bl").GetValue(entity); ;
            entitySearch.geo = (IProperty<T>[])entity.GetType().GetProperty("geo").GetValue(entity); ;
            entitySearch.num64 = (INum64Property[])entity.GetType().GetProperty("num64").GetValue(entity); ;
            entitySearch.str = (IStrProperty[])entity.GetType().GetProperty("str").GetValue(entity); ;
            entitySearch.sug = (IStrProperty[])entity.GetType().GetProperty("sug").GetValue(entity); ;

            return entitySearch;
        }


        /// <summary>
        /// Obtiene 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="implements"></param>
        /// <param name="obj"></param>
        /// <param name="typeToCast"></param>
        /// <param name="collection"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static IEntitySearch<T>[] GetEntitySearch<T>(Implements<T> implements, object obj, Type typeToCast, List<IEntitySearch<T>> collection = null, IEntitySearch<T> parent = null)
        {
            // lista con las entidades
            var list = collection ?? new List<IEntitySearch<T>>();


            // busca la metadata para obtener el índice.
            var entityAttr = Reflection.Attributes.GetAttributes<EntityIndexAttribute>(obj.GetType());
            

            
            // si el objeto no tiene el atributo que lo vincula con una entidad, retornará una colección vacia.
            if (entityAttr == null || !entityAttr.Any())
            {
                return list.ToArray();
            }

            // busca si existen propieades con metadata.
            var values = Reflection.Attributes.GetPropertiesByAttributeWithValue(obj);

            // obtiene todas las propiedades sin metadata.
            // filtra por aquellas propiedades que sean de tipo clase.
            // las propiedades sin metadata se usan para  comprobar  si son una entidad local, es decir tienen el atributo mdm que lo identifica como entidad.
            var valuesWithoutProperty = Reflection.Attributes.GetPropertiesWithoutAttributeWithValues(obj).Where(s=>s.GetType().IsClass);



            // obtiene las propiedades del objeto, sin incorporar las entidades referenciales locales.
            var entitySearch = GetSimpleEntity(implements, obj, typeToCast,  entityAttr.First().Index);


           
            // si la entidad es la inicial, es decir es de referencia (no local), obtendrá el id desde el mismo elemento.
            // si no es el primero será una referencia de tipo local y deberá generarse una nueva entidad con un nuevo id.
            entitySearch.id = parent == null ? obj.GetType().GetProperty("Id").GetValue(obj).ToString() : Guid.NewGuid().ToString("N");



            // si la colección no es nula, significa que pasó por el primer nivel de recursión.
            // si ese es el caso, asignamos la relación con el padre que es asignada como parámetro de entrada.
            if (parent != null)
            {
                var entity = GetEntityProperty(parent.index, parent.id, implements.rel);

                if (entity.Any())
                {
                    var arr = entitySearch.rel.ToList();
                    arr.AddRange(entity);

                    entitySearch.rel = arr.ToArray();
                }

                
            }

            // toma todos los valores de propiedad que sean de tipo local reference o no tengan atributos de metadata y que los valores deben ser clases y no valores primitivos, para poder identificar entidades locales.
            // el método recorrerá el objeto y verificará que tenga el atributo que lo identifique como entidad, sino lo tiene no será reconocido como entidad, no importa si la propiedad tiene el atributo de entidad local.
            // el atributo de la clase es el que vale (EntityIndexAttribute).
            var posibleLocals = valuesWithoutProperty.Union(values.Where(s => s.Key.IsEntity && s.Key.KindIndex == (int)KindEntityProperty.LOCAL_REFERENCE).Select(s => s.Value)).ToList();

           

            // si existen propiedades de tipo clase se comprobará si tienen la etiqueta que los identifica como entidades locales, realizando un método recursivo.
            foreach (var item in posibleLocals)
            {
                // hará una busqueda recursiva de entidades locales con las propiedades que se especifiquen que sean entidades locales o aquellas que no especifiquen pero sea de tipo clase o colleción de clases.
                var locals = posibleLocals.SelectMany(s =>
                    {
                        // si es enumerable deberá generar una entidad por cada registro
                        if (Reflection.IsEnumerable(s))
                        {
                            // por cada elemento verifica si existen entidades locales, si el objeto no es identificado como referencia local, no retornará nada.
                            return ((IEnumerable<object>)s).SelectMany(a => GetEntitySearch<T>(implements, a, typeToCast, new List<IEntitySearch<T>>(), entitySearch));
                        }
                        // si no es una colección retornará una lista de entidades para esta propiedad, si tiene el atributo que lo identifica como identidad local.
                        return GetEntitySearch<T>(implements, item, typeToCast, new List<IEntitySearch<T>>(), entitySearch);
                    }
                ).ToList();

                // dentro de las entidades encontradas chequea si alguna tiene su identificador (del entitySearch actual), para asignarlo en sus relaciones.
                var localsRelated = locals.Where(s => s.rel.Any(a => a.index == entitySearch.index && a.id.Equals(entitySearch.id))).ToList();

                // si encuentra las asociará a la lista de entidades relacionadas.
                if (localsRelated.Any())
                {
                    // recorre las en entidades para asignarla como propiedad de relación de entidades.
                    foreach (var entity in localsRelated)
                    {
                        var arr = entitySearch.rel.ToList();
                        arr.AddRange(GetEntityProperty(entity.index, entity.id, implements.rel));

                        entitySearch.rel = arr.ToArray();
                    }
                }



                list.AddRange(locals);

            }

            // añade el mismo entitySearch a la lista
            list.Add(entitySearch);


            return list.ToArray();


        }


       
    }
}
