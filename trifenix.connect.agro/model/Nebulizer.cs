﻿using Cosmonaut;
using Cosmonaut.Attributes;
using trifenix.agro.db;
using trifenix.connect.agro.index_model.props;
using trifenix.connect.agro.mdm_attributes;
using trifenix.connect.mdm.enums;

namespace trifenix.connect.agro_model
{

    [SharedCosmosCollection("agro", "Nebulizer")]
    [ReferenceSearchHeader(EntityRelated.NEBULIZER, PathName ="nebulizers", Kind = EntityKind.ENTITY)]
    [GroupMenu(MenuEntityRelated.MANTENEDORES, PhisicalDevice.ALL, SubMenuEntityRelated.MAQUINARIA)]
    public class Nebulizer : DocumentBase<long>, ISharedCosmosEntity {

        public override string Id { get; set; }

        /// <summary>
        /// Identificador visual de la entidad certificadora
        /// </summary>
        [AutoNumericSearch(NumRelated.GENERIC_CORRELATIVE)]
        public override long ClientId { get; set; }


        /// <summary>
        /// Marca del tractor
        /// </summary>
        [StringSearch(StringRelated.GENERIC_BRAND)]
        public string Brand { get; set; }


        /// <summary>
        /// Código de la nebulizadora.
        /// </summary>
        [StringSearch(StringRelated.GENERIC_CODE)]
        public string Code { get; set; }

    }
}