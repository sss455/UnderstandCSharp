// ■リスト7-23：変数のスコープのルール2を確認するためのコード
var array = new int[] {5, 8, 4, 9, 5, -3, 6};
var foundIndex = -1;
for (var i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        foundIndex = i;  // 変数iはforループの外では見えないので、foundIndexに代入
        break;
    }
}
if (foundIndex >= 0)  // マイナス値が見つからなかった場合、foundIndexは初期値（-1）のまま
{
    Console.WriteLine($"配列最初のマイナス値は {array[foundIndex]}です。");
}
else
{
    Console.WriteLine("配列にマイナス値はありませんでした。");
}
