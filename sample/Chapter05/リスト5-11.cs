// ■リスト5-11：2重ループとbreak文があるサンプルプログラム
for (var rate = 0.01m; rate <= 0.10m; rate += 0.01m)  // 0.01刻みで0.01（1％）から0.10（10％）まで繰り返している
                                                      // rateは、サフィックスmを付けているので、decimal型（⇒p.72）になる
{
    Console.Write($"rate={rate}: ");
    var sum = 100_000;  // アンダースコア"_"は、桁区切りの記号（⇒p.74）
    for (var n = 1; n <= 10; n++)
    {
        sum += (int)(sum * rate);
        if (sum > 200_000)
        {
            Console.WriteLine($"{n}年後に200,000円を超えました。sum={sum}");
            break;
        }
    }
    if (sum <= 200_000)
    {
        Console.WriteLine($"200,000円を超えませんでした。sum={sum}");
    }
}
Console.WriteLine("ループを終了しました");
