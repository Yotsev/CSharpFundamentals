using System;

namespace _10.RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());

            int totalHeadsets = 0;
            int totalMice = 0;
            int totalKeyboards = 0;
            int totalDisplays = 0;

            double totalExpenses = 0.0;

            if (lostGamesCount >= 2)
            {
                totalHeadsets = lostGamesCount / 2;
            }
            if (lostGamesCount >= 3)
            {
                totalMice = lostGamesCount / 3;
            }
            totalKeyboards = lostGamesCount / 6;
            totalDisplays = totalKeyboards / 2;

            totalExpenses = totalHeadsets * priceOfHeadset + totalMice * priceOfMouse + totalKeyboards * priceOfKeyboard + totalDisplays * priceOfDisplay;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
                
        }
    }
}
