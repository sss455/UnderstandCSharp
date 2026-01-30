// ■リスト7-21：変数のスコープのルール1を確認するためのコード
static void PrintEvenOrOdd(int num)
{
    string str;  // これで変数strのスコープが広くなった
    if (num % 2 == 0)
    {
        str = "偶数";
    }
    else
    {
        str = "奇数";
    }
    Console.WriteLine($"{num}は{str}");
}
