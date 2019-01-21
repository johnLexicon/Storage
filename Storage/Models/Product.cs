﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    /*
    a. int Id
    b. string Name
    c. int Price
    d. DateTime Orderdate
    e. string Category
    f. string Shelf
    g. int Count
    h. string Description
    */
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
