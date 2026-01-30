// ■リスト9-14：文字列を指定した文字で分割する（2）
var str = "吾輩は猫である,夏目漱石";
var items = str.Split(',');  // カンマで分割する
var book = new Book
{
    Title = items[0],  // "吾輩は猫である"がTitleプロパティに代入される
    Author = items[1],  // "夏目漱石"がAuthorプロパティに代入される
};
Console.WriteLine($"{book.Title}, {book.Author}");
