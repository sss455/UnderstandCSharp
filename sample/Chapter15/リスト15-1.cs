// ■リスト15-1：【×】例外が発生するプログラム
class Program
{
    static void Main()
    {
        var total = 1000;
        var line = Console.ReadLine();
        var count = int.Parse(line);  // 数値文字列ではないと例外が発生。int.Parseについてはp.96参照
        var ans = total / count;  // countが0だと例外が発生
        Console.WriteLine(ans);
        Console.WriteLine("正常終了");
    }
}
