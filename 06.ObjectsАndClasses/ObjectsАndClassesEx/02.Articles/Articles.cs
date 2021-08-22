using System;

namespace _02.Articles
{
    class Articles
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int number = int.Parse(Console.ReadLine());

            string titel = article[0];
            string content = article[1];
            string author = article[2];

            Article art = new Article
            {
                Title = titel,
                Content = content,
                Author = author
            };


            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string newInfo = commandArgs[1];


                if (action == "Edit")
                {
                    art.Edit(newInfo);
                }
                else if (action == "ChangeAuthor")
                {
                    art.ChangeAuthor(newInfo);
                }
                else if (action == "Rename")
                {
                    art.Rename(newInfo);
                }
            }

            Console.WriteLine(art);
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor (string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }
}


