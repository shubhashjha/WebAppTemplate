﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities.General
{
    [Table("Products")]
    public class Product : Base<int>
    {
        [Required, StringLength(maximumLength: 8, MinimumLength = 2)]
        public string? Code { get; set; }
        [Required, StringLength(maximumLength: 100, MinimumLength = 2)]
        public string? Name { get; set; }
        [Required]
        public float Price { get; set; }
        [StringLength(maximumLength: 350)]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
