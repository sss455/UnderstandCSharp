// ■リスト12-6：リストから要素を削除する
var lines = new List<string>();
lines.Add("おはよう");
lines.Add("こんにちは");
lines.Add("こんばんは");
lines.Add("おやすみ");
lines.RemoveAt(2);  // linesから2番目の要素を削除
foreach (var s in lines)
{
    Console.WriteLine(s);
}
var count = lines.Count;
Console.WriteLine($"要素数:{count}");
