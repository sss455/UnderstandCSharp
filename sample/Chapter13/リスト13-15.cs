// ■リスト13-15：ToStringメソッドの呼び出し例（1）
var index = 36;
var s1 = index.ToString();  // int型のToStringメソッドを呼び出す
var height = 98.7M;
var s2 = height.ToString();  // decimal型のToStringメソッドを呼び出す
var date = new DateTime(2020, 8, 24);
var s3 = date.ToString();  // DateTime型のToStringメソッドを呼び出す
Console.WriteLine($"{s1} | {s2} | {s3}");
