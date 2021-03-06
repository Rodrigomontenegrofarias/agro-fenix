﻿using System.ComponentModel.DataAnnotations;
using trifenix.connect.agro.index_model.enums;
using trifenix.connect.agro.index_model.props;
using trifenix.connect.agro.mdm_attributes;
using trifenix.connect.agro_model;
using trifenix.connect.input;
using trifenix.connect.mdm.validation_attributes;
using trifenix.connect.mdm_attributes;

namespace trifenix.connect.agro_model_input
{
    /// <summary>
    /// Ingreso de pre orden
    /// </summary>
    [ReferenceSearchHeader(EntityRelated.PREORDER)]
    public class PreOrderInput : InputBase {

        /// <summary>
        /// Nombre
        /// </summary>
        [Required, Unique]
        [SuggestSearch(StringRelated.GENERIC_NAME)]
        public string Name { get; set; }

        /// <summary>
        /// Búsqueda por referencia de la carpeta de ordenes asociada
        /// </summary>
        [Reference(typeof(OrderFolder))]
        [ReferenceSearch(EntityRelated.ORDER_FOLDER)]
        public string OrderFolderId { get; set; }

        /// <summary>
        /// Búsqueda por referencia de ingrediente
        /// </summary>
        [Reference(typeof(Ingredient))]
        public string IdIngredient { get; set; }

        /// <summary>
        /// Tipo de pre orden
        /// </summary>
        [Required]
        [EnumSearch(EnumRelated.PRE_ORDER_TYPE)]
        public PreOrderType PreOrderType { get; set; }
        
        /// <summary>
        /// Búsqueda por referencia de cuartel asociado
        /// </summary>
        [Required, Reference(typeof(Barrack))]
        [ReferenceSearch(EntityRelated.BARRACK)]
        public string[] BarracksId { get; set; }

    }

    

}