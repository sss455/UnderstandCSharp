// ■リスト9-13：文字列を指定した文字で分割する（1）
var str = "銀河鉄道の夜,宮沢賢治";
var items = str.Split(',');  // カンマで分割する。itemsはstringの配列（string[]）になる
Console.WriteLine("Title: {0}", items[0]);
Console.WriteLine("Author: {0}", items[1]);
