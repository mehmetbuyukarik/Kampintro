using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.productName = "Semih";
            product1.productQuantity = 50;
            product1.productPrice = 100;

            Product product2 = new Product();

            product2.productName = "Mehmet ";
            product2.productQuantity = 60;
            product2.productPrice = 80;

            Product product3 = new Product();

            product3.productName = "Merve";
            product3.productQuantity = 40;
            product3.productPrice = 90;

            Product[] Products = new Product[] {product1,product2,product3 };

            foreach (var product in Products)
            {
                Console.WriteLine(product.productName + ":" + product.productQuantity + " - " + product.productPrice);
            }


        }
    }

    class Product
    {
        public  string productName { get; set; }
        public  int productQuantity { get; set; }
        public double productPrice { get; set; }
    }
}
