// ■リスト12-28：Maxメソッドを使ったコード（2）
var books = new List<Book>();

…… // ここでbooksにリスト12-22と同様のBookオブジェクトを追加

var max = books.Max(x => x.Pages);  // 最大のページ数を求める
Console.WriteLine(max);
