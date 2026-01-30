using System;

namespace Chap13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            object book = new Book("人間失格", "太宰治", 212, 4);
            Console.WriteLine(book);
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public Book(string title, string author, int pages, int rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

    }
}