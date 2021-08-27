using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class AdAstra
    {
        static void Main(string[] args)
        {
            string foodInfo = Console.ReadLine();

            string pattern = @"(\||#)(?<itemname>[A-Za-z\s]+)(\1)(?<expirationdate>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d+)(\1)";
            int caloriesNeededParDay = 2000;

            MatchCollection validFood = Regex.Matches(foodInfo, pattern);

            int totalCalories = 0;

            foreach (Match foodItem in validFood)
            {
                totalCalories += int.Parse(foodItem.Groups["calories"].Value);
            }

            int days = totalCalories / caloriesNeededParDay;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match foodItem in validFood)
            {
                Console.WriteLine($"Item: {foodItem.Groups["itemname"]}, Best before: {foodItem.Groups["expirationdate"]}, Nutrition: {foodItem.Groups["calories"]}");
            }
        }
    }
}
