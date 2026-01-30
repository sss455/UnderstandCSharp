// ■リスト7-7：メソッドの定義
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Rating { get; set; }

    public void Print()  // Printメソッドの定義
    {
        Console.WriteLine($"■{this.Title}");
        Console.WriteLine($"  {this.Author}  {this.Pages}ページ  評価: {this.Rating}");
    }
}
