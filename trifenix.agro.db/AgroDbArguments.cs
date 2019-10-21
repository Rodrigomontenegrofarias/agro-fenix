﻿using System;

namespace trifenix.agro.db
{
    public class AgroDbArguments
    {
        /// <summary>
        /// EndPoint of the db
        /// </summary>
        /// <value>
        /// The end point URL.
        /// </value>
        public string EndPointUrl { get; set; }

        /// <summary>
        /// the cosmos db primary key
        /// </summary>
        /// <value>
        /// The primary key.
        /// </value>
        public string PrimaryKey { get; set; }


        /// <summary>
        /// Gets or sets the name of the cosmos database.
        /// </summary>
        /// <value>
        /// The name database.
        /// </value>
        public string NameDb { get; set; }


        //TODO: esto no debería ir acá, debería ir independiente porque esto corresponde a azure search

        public string AzureSearchName { get; set; }

        public string AzureSearchKey { get; set; }
    }
}
