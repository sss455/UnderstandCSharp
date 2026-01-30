// ■リスト12-9：クラスのオブジェクトを要素に持つリストを扱う
var books = new List<Book>();  // Book型のリストを生成
var book1 = new Book("吾輩は猫である", "夏目漱石", 610, 4);  // 1冊目のBook型オブジェクトを生成
books.Add(book1);  // 1冊目を追加。Addメソッドについてはp.334参照
var book2 = new Book("人間失格", "太宰治", 212, 5);
books.Add(book2);  // 2冊目を追加
foreach (var book in books)
{
    Console.WriteLine($"{book.Title} {book.Author} {book.Rating}");
}
