﻿using trifenix.connect.agro.index_model.props;
using trifenix.connect.mdm.enums;

using trifenix.connect.mdm_attributes;

namespace trifenix.connect.agro.mdm_attributes
{
    /// <summary>
    /// atributo utilizado para determinar si un campo es autonumérico.
    /// </summary>
    public class AutoNumericSearchAttribute : AutoNumericDependantAttribute
    {
     
        /// <summary>
        /// indica si una propiedad es autonumérica.
        /// </summary>
        /// <param name="index">índice de la propiedad</param>
        public AutoNumericSearchAttribute(NumRelated index)
        {
            Index = (int)index;
            KindIndex = (int)KindProperty.NUM64;
        }

        /// <summary>
        /// Si un autonumérico depende de otra entidad se podrá indicar en el constructor,
        /// dependerán de otra entidad cuando la generación de la secuencia depende de otra entidad,
        /// por ejemplo un listado de producto que tiene un autonumérico que depende de una factura. todas las facturas empezarían desde cero.
        /// </summary>
        /// <param name="index">índice de la propiedad numérica que será autonumérica</param>
        /// <param name="dependant">índice de la entidad de la que depende</param>
        public AutoNumericSearchAttribute(NumRelated index, EntityRelated dependant): this(index)
        {
            Dependant = (int?)dependant;
            
        }
        

        

    }


}