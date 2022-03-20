﻿using System.ComponentModel.DataAnnotations;

namespace Vega.Models
{
    public class Contact
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}