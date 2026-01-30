using System;

namespace Chap07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1-1, Q1-02 を確かめるコード
            var book = new Book
            {
                Title = "坊っちゃん",
                Author = "夏目漱石",
                Pages = 216,
                Rating = 4,
                Memo = "漱石の初期の代表作のひとつ"
            };
            book.Print();
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        // Q1-1
        public string Memo { get; set; }

        // Q1-2
        public void Print()
        {
            Console.WriteLine($"『{Title}』{Author}");
            Console.WriteLine($"  {Pages}ページ、評価:{Rating}");
            Console.WriteLine($"  {Memo}");
        }
        /* 以下のように出力される （この通りである必要はない）
            『坊っちゃん』夏目漱石
              216ページ、評価:4
              漱石の初期の代表作のひとつ
         */
    }
}