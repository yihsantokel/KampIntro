using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Name = "elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";
            product1.Stock = 1200;

            Products product2 = new Products();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";
            product2.Stock = 100

            Products[] products = new Products[] 
            {product1,product2 };

            //type-safe -- tip güvenli
            foreach (Products product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);                
            }

            Console.WriteLine("---------Methods---------");

            //instance -- örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12);
        }
    }
}

//Don't repeat yourself - DRY - Clean Code




