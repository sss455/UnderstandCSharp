// ■リスト6-8：文字列に対してforeach文を使った例
var str = "abcdefg";
foreach (var ch in str)  // 文字列に対してforeachを使うと文字を1文字ずつ取り出せる。変数chはchar型
{
    Console.Write($"{ch} ");
}
Console.WriteLine();  // 最後に改行だけを行う
