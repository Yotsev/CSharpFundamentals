using System;
using System.Collections.Generic;

namespace _05.HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            string command = Console.ReadLine();

            List<string> articleComments = new List<string>();

            while (command != "end of comments")
            {
                articleComments.Add(command);

                command = Console.ReadLine();
            }

            Console.WriteLine($"<h1>\n\t{articleTitle}\n</h1>");
            Console.WriteLine($"<article>\n\t{articleContent}\n</article>");
            foreach (string comment in articleComments)
            {
                Console.WriteLine($"<div>\n\t{comment}\n</div>");
            }
        }
    }
}
