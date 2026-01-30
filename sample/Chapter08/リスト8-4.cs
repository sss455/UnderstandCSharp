// ■リスト8-4：静的プロパティへのアクセス
var today = DateTime.Today;  // Todayは静的プロパティ、todayはDateTime型
Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日");
