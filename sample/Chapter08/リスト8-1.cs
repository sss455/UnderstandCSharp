// ■リスト8-1：インスタンスプロパティへのアクセス例
var date = new DateTime(2019, 10, 8); // インスタンス生成時に「2019年10月8日」の値を渡す
var year = date.Year;
var month = date.Month;
var day = date.Day;
Console.WriteLine("{0}年{1}月{2}日", year, month, day);
