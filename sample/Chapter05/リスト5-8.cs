// ■リスト5-8：break文の例
for (var i = 0; i < 20; i++)
{
    var s = Console.ReadLine();
    if (s == "")
    {
        break;  // forループから抜け出す
    }
    Console.WriteLine(s);
}
Console.WriteLine("ループを終了しました");
