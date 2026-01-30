// ■リスト8-8：静的メソッドと静的プロパティの定義
class Book
{
    // 静的プロパティ
    public static int Count { get; set; }  // staticキーワードで静的プロパティを定義

    // 静的メソッド
    public static void ClearCount()  // staticキーワードで静的メソッドを定義
    {
        Count = 0;
    }

    public string Title { get; set; }
    public string Author { get; set; }

    public void PrintTitle()
    {
        Console.WriteLine("書籍名: {0}", Title);
        Count++;  // 自分の所属クラスのプロパティなので、Book.Count++; とクラス名を指定する必要はない

        Console.WriteLine(Count);
    }
}
