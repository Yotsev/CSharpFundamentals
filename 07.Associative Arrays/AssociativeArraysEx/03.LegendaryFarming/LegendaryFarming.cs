using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            List<LegendaryItem> legendaryItems = new List<LegendaryItem>
            {
                new LegendaryItem
                {
                    Name = "Shadowmourne",
                    Material = "Shards"
                },
                new LegendaryItem
                {
                    Name = "Valanyr",
                    Material ="Fragments"
                },
                new LegendaryItem
                {
                    Name = "Dragonwrath",
                    Material = "Motes"
                }
            };

            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>
            {
                {"shards",0 },    
                {"fragments",0 }, 
                {"motes",0 }      
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            int neededMaterial = 250;
            string farmedMaterial = string.Empty;
            bool doneFarming = false;

            for (int i = 0; ; i++)
            {
                if (doneFarming)
                {
                    break;
                }

                string[] materials = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < materials.Length; j += 2)
                {
                    bool isKey = false;

                    string materialName = materials[j + 1].ToLower();
                    int materialQuantity = int.Parse(materials[j]);

                    foreach (LegendaryItem item in legendaryItems)
                    {
                        if (item.Material.ToLower() == materialName)
                        {
                            isKey = true;
                            break;
                        }
                    }

                    if (isKey)
                    {
                        legendaryMaterials[materialName] += materialQuantity;

                        foreach (var item in legendaryMaterials)
                        {
                            if (item.Key.ToLower() == materialName)
                            {
                                if (item.Value >= neededMaterial)
                                {
                                    doneFarming = true;
                                    farmedMaterial = item.Key;
                                    legendaryMaterials[materialName] -= neededMaterial;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(materialName))
                        {
                            junkMaterials.Add(materialName, materialQuantity);
                        }
                        else
                        {
                            junkMaterials[materialName] += materialQuantity;
                        }
                    }

                    if (doneFarming)
                    {
                        break;
                    }
                }
            }

            List<KeyValuePair<string, int>> sortedLegendayMaterials = legendaryMaterials.OrderByDescending(q => q.Value).ThenBy(n => n.Key).ToList();
            List<KeyValuePair<string, int>> sorterJunkMaterials = junkMaterials.OrderBy(n => n.Key).ToList();

            foreach (LegendaryItem item in legendaryItems)
            {
                if (item.Material.ToLower() == farmedMaterial)
                {
                    Console.WriteLine($"{item.Name} obtained!");
                    break;
                }
            }

            foreach (var material in sortedLegendayMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in sorterJunkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }

    class LegendaryItem
    {
        public string Name { get; set; }
        public string Material { get; set; }
    }
}



