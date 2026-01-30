// ■リスト5-4：昭和と西暦の対応表出力プログラム（for文使用）
for (var year = 1; year <= 64; year++)
{
    var westernYear = year + 1925;
    Console.WriteLine($"昭和{year}年 {westernYear}年");
}
