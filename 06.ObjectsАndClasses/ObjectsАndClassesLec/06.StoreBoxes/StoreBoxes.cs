using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class StoreBoxes
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = itemQuantity;
                box.PricePerBox = box.Item.Price * box.Quantity;

                boxes.Add(box);

                command = Console.ReadLine();
            }

            List<Box> ordered = boxes.OrderByDescending(i => i.PricePerBox).ToList();

            foreach (var box in ordered)
            {
                Console.WriteLine($"{box.SerialNumber}\n-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}\n-- ${box.PricePerBox:f2}");
            }

        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerBox { get; set; }
    }
}
