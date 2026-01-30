// ■リスト5-10：continue文の例
for (var i = 0; i < 50; i++)
{
    if (i % 13 != 0)
    {
        continue;  // 13で割って余りが0でないなら（＝割り切れなければ）、ここでfor文の先頭に戻って処理を続ける
    }
    Console.WriteLine($"{i}は13で割り切れる数です");
}
