﻿using System;

namespace _05.Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = OrderPrice(product, quantity);
            
            Console.WriteLine($"{price:f2}");
        }

        static double OrderPrice(string product, int quantity)
        {
            double price = 0.0;

            if (product== "coffee")
            {
                price = 1.50;
            }
            else if (product== "water")
            {
                price = 1.00;
            }
            else if (product== "coke")
            {
                price = 1.40;
            }
            else if (product== "snacks")
            {
                price = 2.00;
            }

            double totalPrice = quantity * price;
            return totalPrice;
        }
    }
}
