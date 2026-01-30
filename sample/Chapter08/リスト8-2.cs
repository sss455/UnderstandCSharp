// ■リスト8-2：インスタンスメソッドの呼び出し例
var date = new DateTime(2019, 4, 30); // 2019年4月30日のインスタンスを生成
var date1 = date.AddDays(1);  // 1日後を求める
var date2 = date.AddMonths(6);  // 6カ月後を求める
Console.WriteLine(date1);
Console.WriteLine(date2);
