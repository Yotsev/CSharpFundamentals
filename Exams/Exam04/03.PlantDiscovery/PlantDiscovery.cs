using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class PlantDiscovery
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string[] plantInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = plantInfo[0];
                int plantRarity = int.Parse(plantInfo[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, new Plant(plantName, plantRarity));
                }
                else
                {
                    Plant plant = GetPlant(plantName, plants);
                    plant.Rarity = plantRarity;
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandArgs = command
                    .Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string plantName = commandArgs[1];
                bool notValid = true;


                if (action == "Rate")
                {
                    int rating = int.Parse(commandArgs[2]);

                    Plant plant = GetPlant(plantName, plants);

                    if (plant != null)
                    {
                        plant.Rating.Add(rating);
                        notValid = false;
                    }

                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(commandArgs[2]);

                    Plant plant = GetPlant(plantName, plants);

                    if (plant != null)
                    {
                        plant.Rarity = newRarity;
                        notValid = false;
                    }
                }
                else if (action == "Reset")
                {
                    Plant plant = GetPlant(plantName, plants);

                    if (plant != null)
                    {
                        plant.Rating.Clear();
                        notValid = false;
                    }
                }

                if (notValid)
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (KeyValuePair<string, Plant> plant in plants.OrderByDescending(r => r.Value.Rarity).ThenByDescending(a => a.Value.AvgRating))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AvgRating:f2}");
            }
        }

        static Plant GetPlant(string plantName, Dictionary<string, Plant> plants)
        {
            foreach (KeyValuePair<string, Plant> plant in plants)
            {
                if (plant.Key == plantName)
                {
                    return plant.Value;
                }
            }

            return null;
        }
    }
    class Plant
    {
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Rating = new List<int>();
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }
        public double AvgRating
        {

            get
            {
                double ratingSum = 0.0;

                foreach (var rate in Rating)
                {
                    ratingSum += rate;
                }

                double avg = ratingSum / Rating.Count;

                if (Rating.Count == 0)
                {
                    return 0.0;
                }

                return avg;
            }
        }
    }
}
