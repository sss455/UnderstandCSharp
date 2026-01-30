// ■リスト5-3：複合した条件の場合のwhile文
var num = 0;
while (num <= 0 || 5 <= num)  // numが0以下あるいは5以上のときは繰り返す
{
    Console.WriteLine("1、2、3、4のいずれかを入力してください。");
    var line = Console.ReadLine();
    num = int.Parse(line);
}
Console.WriteLine($"{num}が入力されました。");
