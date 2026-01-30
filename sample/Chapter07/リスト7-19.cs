// ■リスト7-19：変数の有効範囲（スコープ）を確認するためのコード
class Program
{
    // Mainメソッド
    static void Main()
    {
        var num = 10;
        Console.WriteLine(num);
        Print();
        Console.WriteLine(num);
    }

    // Printメソッド
    static void Print()
    {
        var num = 123;  // Mainメソッドのnumとは別のもの
        Console.WriteLine(num);
    }
}
