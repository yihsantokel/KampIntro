using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Masa";
            product1.UnitPrice = 50;
            product1.UnitInStock = 99;




            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }
    }
}
