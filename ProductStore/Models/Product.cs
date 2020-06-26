using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Must be Upper Case, no spaces")]
        [MaxLength(30, ErrorMessage = "Must be Maximum 30 Characters")]
        public string Name { get; set; }
        public string Category { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Price { get; set; }
    }
}