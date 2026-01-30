// ■リスト4-2：if-else文の例
var line = Console.ReadLine();
var num = int.Parse(line);
if (num % 2 == 0)  // numを2で割った余りが0ならば……
{
    Console.WriteLine("偶数です");
}
else  // そうでないなら……
{
    Console.WriteLine("奇数です");  // num % 2 == 0 が成り立たないときに処理される
}
