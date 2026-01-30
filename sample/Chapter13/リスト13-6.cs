// ■リスト13-6：基底クラスにメソッドを定義する
class Person
{
    ……  // リスト13-2のコード

    public void Print()
    {
        Console.WriteLine($"名前: {FullName} ({Email})");
    }
}
