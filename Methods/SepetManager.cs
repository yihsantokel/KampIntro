using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax -- Java ile C# birbirine çok benzer
        public void Add(Products product)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string description, double fiyat)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + productName);
        }
    }
}
