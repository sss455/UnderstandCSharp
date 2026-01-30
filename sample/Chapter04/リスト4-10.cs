// ■リスト4-10：else if構文を使った多分岐処理
var temperature = 29.5;

if (temperature >= 35.0)
{
    Console.WriteLine("猛暑日です");
}
else if (temperature >= 30.0)
{
    Console.WriteLine("真夏日です");
}
else if (temperature >= 25.0)
{
    Console.WriteLine("夏日です");
}
else
{
    Console.WriteLine("いずれでもありません");
}
