// ■リスト9-7：部分文字列を取り出す
var str = "オブジェクト指向";
var sub1 = str.Substring(0, 6);  // 開始位置0から6文字を取り出して新たな文字列を得る
var sub2 = str.Substring(6, 2);  // 開始位置6から2文字を取り出して新たな文字列を得る
Console.WriteLine(str);
Console.WriteLine(sub1);
Console.WriteLine(sub2);
