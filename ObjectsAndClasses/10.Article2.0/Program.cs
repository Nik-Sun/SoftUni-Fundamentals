using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for (int i = 0; i < articlesCount; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article currentArticle = new Article(input[0],input[1],input[2]);
                listOfArticles.Add(currentArticle);
            }
            ListOfArticles articles = new ListOfArticles();
            articles.Articles = listOfArticles;
            string sortBy = Console.ReadLine();
            articles.Sort(sortBy);

            foreach (var item in articles.Articles)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }



        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
 
    }
    class ListOfArticles
    {
        public List<Article> Articles { get; set; }
        public void Sort(string sortBy) 
        {
            List<Article> sortedList = new List<Article>();
            if (sortBy=="author")
            {
               sortedList = Articles.OrderBy(x => x.Author).ToList();
            }
            else if (sortBy=="content")
            {
                sortedList = Articles.OrderBy(x => x.Content).ToList();
            }
            else if (sortBy=="title")
            {
                sortedList = Articles.OrderBy(x => x.Title).ToList();
            }
            
           
            
            Articles = sortedList;
        }
    }
    
}
