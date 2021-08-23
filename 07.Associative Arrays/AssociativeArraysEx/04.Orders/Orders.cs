using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (command != "buy")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string productName = commandArgs[0];
                decimal productPrice = decimal.Parse(commandArgs[1]);
                int productQuantity = int.Parse(commandArgs[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new Product(productName, productPrice, productQuantity));
                }
                else
                {
                    products[productName].Quantity += productQuantity;
                    
                    if (products[productName].Price != productPrice)
                    {
                        products[productName].Price = productPrice;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Product> produc in products)
            {
                Console.WriteLine($"{produc.Value.Name} -> {produc.Value.TotalPrice:f2}");
            }
        }
    }

    class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
