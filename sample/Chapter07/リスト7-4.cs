// ■リスト7-4：プロパティを直接参照する
var book = new Book();
book.Title = "吾輩は猫である";
book.Author = "夏目漱石";
book.Pages = 610;
book.Rating = 4;
Console.WriteLine($"書籍名: {book.Title}");  // bookオブジェクトのTitleの値を取り出している
Console.WriteLine($"著者名: {book.Author}");
Console.WriteLine($"ページ数: {book.Pages}");
Console.WriteLine($"評価: {book.Rating}");
