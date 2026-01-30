// ■リスト4-3：if文の入れ子
if (x == 0)
{
    Console.WriteLine("xは0です");
    if (y == 0)  // if文の中にif文を書ける
    {
        Console.WriteLine("yも0です");
    }
}
