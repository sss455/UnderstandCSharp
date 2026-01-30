// ■リスト9-23：N日後を得る
var date1 = new DateTime(2020, 9, 10);
var date2 = date1.AddDays(10);  // 10日後の日付を求める
Console.WriteLine($"{date2.Year}年{date2.Month}月{date2.Day}日");
