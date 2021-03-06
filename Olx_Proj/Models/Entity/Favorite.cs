﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Olx_Proj.Models.Entity
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Tovar")]
        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
