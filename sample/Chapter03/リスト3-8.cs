// ■リスト3-8：double型からint型へのキャスト
var source = 15.8;
var width = (int)source;  // int型に変換。小数点以下は切り捨てられる
Console.WriteLine(width);
