﻿using System.Collections.Generic;
using NorthwindTrader.Entities.Abstract;

namespace NorthwindTrader.Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }

    }
}