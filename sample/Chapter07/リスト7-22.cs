// ■リスト7-22：【×】変数のスコープのルール2を確認するためのコード（コンパイルエラー）
var array = new int[] {5, 8, 4, 9, 5, -3, 6};
for (var i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        break;  // ループから脱出する（break;の振る舞いについては、p.117を参照）
    }
}
if (i < array.Length)  // ループカウンターiは利用できないので、ここでコンパイルエラー
{
    Console.WriteLine($"配列最初のマイナス値は {array[i]}です。");
}
else
{
    Console.WriteLine("配列にマイナス値はありませんでした。");
}
