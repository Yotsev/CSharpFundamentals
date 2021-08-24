using System;

namespace _02.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];

            int result = MultiplayCharacters(first, second);

            Console.WriteLine(result);
        }

        static int MultiplayCharacters(string first, string second)
        {
            int sum = 0;

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else if (second.Length> first.Length)
            {
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }

            return sum;
        }
    }
}
