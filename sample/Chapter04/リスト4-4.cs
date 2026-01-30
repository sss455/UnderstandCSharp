// ■リスト4-4：if文の例（数値の比較）（2）
var line = Console.ReadLine();
var num = int.Parse(line);
if (num >= 10)  // もし num >= 10 が成り立つなら……
{
    Console.WriteLine("num >= 10が成り立ちました。");
    Console.WriteLine($"num の値は {num} です。");
}
