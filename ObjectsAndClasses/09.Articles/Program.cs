using System;

namespace _09.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine().Split(", ");
            Article article = new Article(initialArticle[0], initialArticle[1], initialArticle[2]);
           
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string change = command[0];
                string content = command[1];
                if (change=="Edit")
                {
                    article.Edit(content);
                }
                else if (change == "ChangeAuthor")
                {
                    article.ChangeAuthor(content);
                }
                else if (change == "Rename")
                {
                    article.Rename(content);
                }
                

            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title,string content,string author) 
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string s) 
        {
            Content = s;
            
        }
        public void ChangeAuthor(string s)
        {
            Author = s;
            
        }
        public void Rename(string s)
        {
            Title = s;
            
        }
        public void Print()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}
