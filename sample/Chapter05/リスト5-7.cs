// ■リスト5-7：2重ループを利用した掛け算九九のプログラム
for (var x = 1; x <= 9; x++)
{
    for (var y = 1; y <= 9; y++)
    {
        var n = x * y;
        Console.WriteLine($"{x} × {y} = {n}");
    }
}
