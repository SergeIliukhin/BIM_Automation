﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public Product(int productID, string productName, decimal productPrice)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
