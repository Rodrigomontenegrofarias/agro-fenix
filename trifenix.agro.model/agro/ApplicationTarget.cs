﻿using Cosmonaut;
using Cosmonaut.Attributes;

namespace trifenix.agro.db.model.agro
{

    [SharedCosmosCollection("agro", "ApplicationTarget")]
    public class ApplicationTarget : DocumentBase, ISharedCosmosEntity
    {
        public override string Id { get; set; }

        public string Name { get; set; }



    }
}
