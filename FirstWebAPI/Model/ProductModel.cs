﻿using System.ComponentModel.DataAnnotations;

namespace ElectronixWebAPI.Model
{
    public class ProductModel
    {
        public int id { get; set; } 
        public string name { get; set; } = string.Empty;
        public string brand { get; set; } = string.Empty;
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
}
