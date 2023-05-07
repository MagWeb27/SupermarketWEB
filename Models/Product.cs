﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]

        public decimal Price { get; set; }

        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Category>? Categories { get; set; } = default!;
    }
}
