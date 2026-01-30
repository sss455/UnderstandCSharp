// ■リスト7-2：プロパティへの代入
class Program
{
    static void Main()
    {
        var book = new Book();
        // bookオブジェクトのプロパティに代入している
        book.Title = "吾輩は猫である";  
        book.Author = "夏目漱石";    
        book.Pages = 610;         
        book.Rating = 4;          
        ……
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Rating { get; set; }
}
