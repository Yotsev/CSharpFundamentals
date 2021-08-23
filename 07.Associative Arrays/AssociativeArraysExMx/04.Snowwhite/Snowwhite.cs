using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<Dwarf>> colors = new Dictionary<string, List<Dwarf>>();

            while (input != "Once upon a time")
            {
                string[] inputArgs = input
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = inputArgs[0];
                string dwarfHatColor = inputArgs[1];
                int dwarfPhysic = int.Parse(inputArgs[2]);

                if (!colors.ContainsKey(dwarfHatColor))
                {
                    colors.Add(dwarfHatColor, new List<Dwarf>());
                    colors[dwarfHatColor].Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysic));
                }
                else
                {
                    Dwarf existingDwarf = GetDwarf(colors, dwarfName);

                    if (existingDwarf == null)
                    {
                        colors[dwarfHatColor].Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysic));
                    }
                    else
                    {
                        if (existingDwarf.HatColor == dwarfHatColor && existingDwarf.Name == dwarfName)
                        {
                            if (existingDwarf.Physic < dwarfPhysic)
                            {
                                existingDwarf.Physic = dwarfPhysic;
                            }
                        }
                        else
                        {
                            colors[dwarfHatColor].Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysic));
                        }
                    }
                }


                input = Console.ReadLine();
            }


            List<Dwarf> dwarfs = new List<Dwarf>();

            foreach (var color in colors)
            {
                foreach (var dwarf in color.Value)
                {
                    dwarfs.Add(dwarf);
                }
            }

            // https://softuni.bg/forum/21189/problem-4-snowwhite - за сортирането
            //dwarfs = dwarfs.OrderByDescending(p => p.Physic).ThenByDescending(x => dwarfs.Count(y => y.HatColor == x.HatColor)).ToList();

            dwarfs = dwarfs.OrderByDescending(p => p.Physic).ThenByDescending(c => colors[c.HatColor].Count).ToList();

            foreach (var dwarf in dwarfs)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physic}");
            }
        }

        private static Dwarf GetDwarf(Dictionary<string, List<Dwarf>> colors, string dwarfName)
        {
            foreach (var color in colors)
            {
                foreach (var dwarf in color.Value)
                {
                    if (dwarf.Name == dwarfName)
                    {
                        return dwarf;
                    }
                }
            }

            return null;
        }
    }

    class Dwarf
    {
        public Dwarf(string name, string color, int physic)
        {
            Name = name;
            HatColor = color;
            Physic = physic;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physic { get; set; }

    }
}
