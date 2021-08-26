using System;

namespace _01.BlackFlag
{
    class BlackFlag
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0.0;

            int cout = 1;
            while (cout <= days)
            {
                totalPlunder += plunder;
                if (cout % 3 == 0)
                {
                    totalPlunder += plunder * 0.5;
                }
                if (cout % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }
                cout++;
            }

            double plunderPercent = totalPlunder/expectedPlunder*100;

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {plunderPercent:f2}% of the plunder.");
            }
        }
    }
}
