using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int currentEnergy = initialEnergy;
            int wins = 0;
            bool isExhausted = false;
            
            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (currentEnergy >= distance)
                {
                    currentEnergy -= distance;
                    wins++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {currentEnergy} energy");
                    isExhausted = true;
                    break;
                }
                if (wins%3 == 0)
                {
                    currentEnergy += wins;
                }

                command = Console.ReadLine();
            }

            if (!isExhausted)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {currentEnergy}");
            }
        }
    }
}
