using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));

            Ex01(books);
            Console.WriteLine();

            Ex02(books);
            Console.WriteLine();

            Ex03(books);
            Console.WriteLine();

            Ex04(books);
        }

        // Q2-1
        private static void Ex01(List<Book> books)
        {
            var query = books.Where(x => x.Rating >= 4);
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        // Q2-2
        private static void Ex02(List<Book> books)
        {
            var query = books.OrderBy(x => x.Author);
            foreach (var book in query)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        // Q2-3
        private static void Ex03(List<Book> books)
        {
            var array = books.Where(x => x.Pages >= 300)
                             .ToArray();
            foreach (var book in array)
            {
                Console.WriteLine($"{book.Title} {book.Pages}");
            }
        }

        // Q2-4
        private static void Ex04(List<Book> books)
        {
            var book = books.OrderByDescending(x => x.Pages)
                            .First();
            Console.WriteLine($"{book.Title} {book.Pages}");
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
