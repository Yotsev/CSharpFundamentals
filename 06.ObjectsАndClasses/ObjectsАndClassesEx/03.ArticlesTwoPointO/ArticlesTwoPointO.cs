using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ArticlesTwoPointO
{
    class ArticlesTwoPointO
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articlaeInfo = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string titel = articlaeInfo[0];
                string content = articlaeInfo[1];
                string author = articlaeInfo[2];

                Article article = new Article
                {
                    Title = titel,
                    Content = content,
                    Author = author
                };

                articles.Add(article);
            }

            string sortParam = Console.ReadLine();

            List<Article> sortedArticles = new List<Article>();

            if (sortParam == "title")
            {
                sortedArticles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (sortParam == "content")
            {
                sortedArticles = articles.OrderBy(a => a.Content).ToList();
            }
            else if (sortParam == "author")
            {
                sortedArticles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (Article article in sortedArticles)
            {
                Console.WriteLine(article);
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
