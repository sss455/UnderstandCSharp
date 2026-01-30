// ■リスト12-24：メソッドを連結させる（3）
var books = new List<Book>();

  ……  // ここでbooksにリスト12-22と同様のBookオブジェクトを追加

var query = books.Where(x => x.Rating >= 4)  // Rating >= 4の書籍を抜き出し……
                 .Select(x => x.Author)  // その著者を取り出し……
                 .Distinct();  // 重複を排除する
foreach (var author in query)
{
    Console.WriteLine(author);
}
