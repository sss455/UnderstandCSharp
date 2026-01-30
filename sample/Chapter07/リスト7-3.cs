// ■リスト7-3：プロパティの参照（変数を介する）
var book = new Book();
book.Title = "吾輩は猫である";
book.Author = "夏目漱石";
book.Pages = 610;
book.Rating = 4;

var title = book.Title;  // bookオブジェクトのTitleの値を取り出している
var author = book.Author;
var pages = book.Pages;
var rating = book.Rating;

Console.WriteLine($"書籍名: {title}");
Console.WriteLine($"著者名: {author}");
Console.WriteLine($"ページ数: {pages}");
Console.WriteLine($"評価: {rating}");
