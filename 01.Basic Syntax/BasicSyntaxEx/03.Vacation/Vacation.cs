using System;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (day.Equals("Friday"))
                    {
                        price = 8.45;
                    }
                    else if (day.Equals("Saturday"))
                    {
                        price = 9.80;
                    }
                    else if (day.Equals("Sunday"))
                    {
                        price = 10.46;
                    }
                    totalPrice = price * groupOfPeople;

                    if (groupOfPeople >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    if (day.Equals("Friday"))
                    {
                        price = 10.90;
                    }
                    else if (day.Equals("Saturday"))
                    {
                        price = 15.60;
                    }
                    else if (day.Equals("Sunday"))
                    {
                        price = 16;
                    }
                    totalPrice = price * groupOfPeople;

                    if (groupOfPeople >= 100)
                    {
                        totalPrice -= price * 10;
                    }
                    break;
                case "Regular":
                    if (day.Equals("Friday"))
                    {
                        price = 15;
                    }
                    else if (day.Equals("Saturday"))
                    {
                        price = 20;
                    }
                    else if (day.Equals("Sunday"))
                    {
                        price = 22.50;
                    }
                    totalPrice = price * groupOfPeople;

                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
