// ■リスト15-11：TryParseメソッドによる文字列から数値への変換
static void Main()
{
    var price = GetPrice();
    var discount = (int)(price * 0.01);
    Console.WriteLine($"割引額{discount}円");
}

private static int GetPrice()
{
    while (true)  // returnで脱出するまで繰り返す
    {
        Console.WriteLine("金額を入力してください。");
        var line = Console.ReadLine();
        if (int.TryParse(line, out var num))  // TryParseを使うと例外が発生しない
        {
            // 変換に成功。変換した値は変数numに格納される
            return num;  // メソッドから脱出
        }
        // 変換に失敗。再度繰り返す
        Console.WriteLine("入力に誤りがあります。");
    }
}
