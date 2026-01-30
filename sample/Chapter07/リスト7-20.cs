// ■リスト7-20：【×】変数のスコープのルール1を確認するためのコード（コンパイルエラー）
static void PrintEvenOrOdd(int num)
{
    if (num % 2 == 0)
    {
        var str = "偶数";  // このstrは{}内で有効
    }
    else
    {
        var str = "奇数";  // このstrも{}内で有効
    }
    Console.WriteLine(str);  // コンパイルエラー。ここでは、strにアクセスできない！
}
