// ■リスト12-15：クラスのコレクションに対してLINQを使う
var books = new List<Book>();
books.Add(new Book("人間失格", "太宰治", 212, 5));
books.Add(new Book("女生徒", "太宰治", 279, 4));
books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
var query = books.Where(x => x.Author == "夏目漱石");  // 著者が夏目漱石の書籍だけ取り出す
foreach (var book in query)
{
    Console.WriteLine($"{book.Title} {book.Author} {book.Rating}");
}
