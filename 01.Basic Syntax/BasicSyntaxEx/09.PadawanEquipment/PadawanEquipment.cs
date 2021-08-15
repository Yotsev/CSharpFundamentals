using System;

namespace _09.PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int stundents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling(stundents + stundents * 0.1);
            double robes = stundents;
            double belts = stundents;

            double totalPriceOfLightsebers = lightsabers * priceOfLightsaber;
            double totalPriceOfRobes = robes * priceOfRobe;
            double totalPriceOfBelts = belts * priceOfBelts;

            if (belts >= 6)
            {
                int numberOfFreeBelts = (int)(belts / 6);
                totalPriceOfBelts -= numberOfFreeBelts * priceOfBelts;
            }

            double totalExpenses = totalPriceOfLightsebers + totalPriceOfRobes + totalPriceOfBelts;

            if (money >= totalExpenses)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalExpenses - money):f2}lv more.");
            }
        }
    }
}
