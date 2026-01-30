// ■リスト12-26：Sumメソッドを使ったコード（2）
var books = new List<Book>();

……  // ここでbooksにリスト12-22と同様のBookオブジェクトを追加

var sum = books.Sum(x => x.Pages);  // ページ数の合計を求める
Console.WriteLine(sum);
