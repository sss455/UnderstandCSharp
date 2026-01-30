// ■リスト13-14：引数にobject型をとるメソッド
class Program
{
    static void Main()
    {
        var book = new Book();
        DoSomething(book);
    }

    public static void DoSomething(object obj)  // 引数にobject型をとるメソッド
    {
        ……
    }
}

class Book
{
    ……
}
