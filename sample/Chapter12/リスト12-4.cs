// ■リスト12-4：リスト内のすべての要素を順に取り出す
var lines = new List<string>();
lines.Add("おはよう");
lines.Add("こんにちは");
lines.Add("こんばんは");
lines.Add("おやすみ");
foreach (var s in lines)  // 配列と同様、foreachで要素を順に取り出せる
{
    Console.WriteLine(s);
}
