// ■リスト9-24：N日前を得る
var date1 = new DateTime(2020, 9, 3);
var date2 = date1.AddDays(-7);  // 7日前の日付を求める
Console.WriteLine($"{date2.Year}年{date2.Month}月{date2.Day}日");
