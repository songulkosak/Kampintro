﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager  //ürünle ilgili operasyonları bulundurur
    {
        public void Add( Product product)
        {
            Console.WriteLine(product.ProductName + "eklnedi.");
        }

        public void Update( Product product ) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        
    }
}
