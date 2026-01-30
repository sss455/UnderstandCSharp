// ■リスト3-10：文字列を数値型に変換する
var total = 100;
var line = Console.ReadLine();
var count = int.Parse(line);  // 文字列をint型に変換する
var num = total / count;
Console.WriteLine(num);
