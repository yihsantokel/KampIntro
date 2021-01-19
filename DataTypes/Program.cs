using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte by = 111;
            ulong ulo = 128983928103;

            //"? :" case demo
            int x = 45;
            double y = 43.99;
            string cond = x > y ? "x is greater than y" :
                x < y ? "y is greater than x" :
                    x == y ? "x and y are equal" : "no result";
            Console.WriteLine(cond);

            //switch case demo
            int all_digits = 950;
            switch (all_digits)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("The number is not a digit");
                    break;
            }
            // while loop demo
            int i = 1;
            while (i<=25)
            {
                Console.WriteLine(i);
                i=i+3;
            }
            // class demo

            Product product1 = new Product();
            product1.BrandName = "Heyner";
            product1.ProductName = "Isofix Oto Koltuğu";
            product1.ProductDescription = "9-36 kg çocuklar için rahatlıkla kullanılabilir";
            product1.ProductPrice = 1389.2;
            product1.ProductRating = 4.84;
            product1.ProductRatingCount = 113;

            Product product2 = new Product();
            product2.BrandName = "Yoyko";
            product2.ProductName = "Dönebilir Yatabilir Oto Koltuğu";
            product2.ProductDescription = "0-36 kg çocuklar için rahatlıkla kullanılabilir";
            product2.ProductPrice = 950.27;
            product2.ProductRating = 4.71;
            product2.ProductRatingCount = 47;

            Product product3 = new Product();
            product3.BrandName = "Huggy";
            product3.ProductName = "Isofix Oto Koltuğu";
            product3.ProductDescription = "9-36 kg çocuklar için rahatlıkla kullanılabilir";
            product3.ProductPrice = 664.05;
            product3.ProductRating = 4.09;
            product3.ProductRatingCount = 7;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.BrandName + ", " + product.ProductName + ", " + product.ProductDescription);
            }
            if (product1.ProductRating<4.85)
            {
                Console.WriteLine("Rating is not enough to buy");
            }
            else
            {
                Console.WriteLine("Product is good enough to buy");
            }

        }
            
        }
    }
    class Product
    {
    public string BrandName { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public double ProductPrice { get; set; }
    public double ProductRating { get; set; }
    public int ProductRatingCount { get; set; }
}
