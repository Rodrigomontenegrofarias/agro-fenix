﻿
using System.ComponentModel.DataAnnotations;
using trifenix.connect.agro_model;
using trifenix.connect.input;
using trifenix.connect.mdm.validation_attributes;

namespace trifenix.connect.agro_model_input
{
    public class CommentInput : InputBase {

        [Required]
        public string Commentary { get; set; }

        [Required, Reference(typeof(User))]
        public string IdUser { get; set; }

        [Required]
        public int EntityIndex { get; set; }

        [Required]
        public string EntityId { get; set; }
    }

    public class CommentSwaggerInput  {
        public string Commentary { get; set; }

        public string IdUser { get; set; }

        public int EntityIndex { get; set; }

        public string EntityId { get; set; }
    }

}