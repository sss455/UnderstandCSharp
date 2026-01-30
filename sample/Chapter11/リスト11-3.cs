// ■リスト11-3：列挙型を利用する
var week = DayOfWeek.Sunday;  // DayOfWeekは列挙型
if (week == DayOfWeek.Friday)  // DayOfWeekという列挙型の名前も必要
{
    Console.WriteLine("金曜日です");
}
else
{
    Console.WriteLine("金曜日ではありません");
}
