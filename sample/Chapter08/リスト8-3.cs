// ■リスト8-3：静的メソッドの呼び出し例
var isLeapYear = DateTime.IsLeapYear(2020);  // IsLeapYearは静的メソッド
if (isLeapYear)
{
    Console.WriteLine("うるう年です");
}
