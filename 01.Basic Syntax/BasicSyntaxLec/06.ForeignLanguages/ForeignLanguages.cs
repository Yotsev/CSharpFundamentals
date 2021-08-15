using System;

namespace _06.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            string county = Console.ReadLine();

            switch (county)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
