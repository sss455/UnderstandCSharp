using System;

namespace Chap10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q4-2 インスタンスを生成
            var book = new Book("斜陽", "太宰治");
            // コンストラクタで設定できないプロパティの値を初期化
            book.Pages = 256;
            book.Rating = 4;
            // Q4-3 Printメソッドの呼び出し
            book.Print();
        }
    }

    // Q4-1 コンストラクターを定義したBookクラス
    class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public void Print()
        {
            Console.WriteLine($"■{Title}");
            Console.WriteLine($"  {Author}  {Pages}ページ  評価: {Rating}");
        }
    }
}
