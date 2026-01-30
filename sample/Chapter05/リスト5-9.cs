// ■リスト5-9：break文の例（2重ループの中）
for (var i = 0; i < 10; i++)
{
    var x = 0;
    while (x < 20)
    {
        if (x == 5)
        {
            break;  // whileループから抜け出す
        }
        x++;
    }
    Console.WriteLine($"whileループ終了 i={i} x={x}");
    if (i == 3)
    {
        break;  // forループから抜け出す
    }
}
Console.WriteLine("forループ終了");
