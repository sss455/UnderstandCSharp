// ■リスト10-3：クラスのオブジェクトを返すメソッド
public static Book MakeBookObject()  // Book型を返すメソッド
{
    Console.Write("書籍名⇒");
    var title = Console.ReadLine();
    Console.Write("著者名⇒");
    var author = Console.ReadLine();
    Console.Write("ページ数⇒");
    var pages = Console.ReadLine();
    var book = new Book
    {
        Title = title,
        Author = author,
        Pages = int.Parse(pages),
        Rating = 3
    };
    return book;  // Bookオブジェクトを返す
}
