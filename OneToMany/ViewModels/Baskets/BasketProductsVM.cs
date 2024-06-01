﻿using System;
using OneToMany.Models;

namespace OneToMany.ViewModels.Baskets
{
	public class BasketProductsVM
	{
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
        public int Count { get; set; }
    }
}
