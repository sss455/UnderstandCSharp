// ■リスト5-2：昭和と西暦の対応表出力プログラム（while文使用）
var year = 1;
while (year <= 64)  // yearが64以下ならば{}の中を繰り返す
{
    var westernYear = year + 1925;
    Console.WriteLine($"昭和{year}年 {westernYear}年");
    year += 1;  // この行がないといつまでも処理が終わらない
}
