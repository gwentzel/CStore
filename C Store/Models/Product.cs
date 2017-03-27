using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace C_Store.Models
{
    public class Product
  // Set up  Product class fields

    {
        [ScaffoldColumn(false)]
            public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }

    }
}