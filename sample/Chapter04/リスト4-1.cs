// ■リスト4-1：if文の例（数値の比較）（1）
var line = Console.ReadLine();
var num = int.Parse(line);
if (num == 10)  // もしnumの値が10だったら……
{
    Console.WriteLine("10が入力されました");  // numが10のときだけ実行される
}
