// ■リスト15-7：例外オブジェクトを参照する
try
{
    Book book = null;  // nullについてはp.324を参照
    var title = book.Title;  // bookはnullなので、Titleを参照できず例外が発生
    Console.WriteLine(title);
}
catch (Exception ex)
{
    Console.WriteLine($"Type: {ex.GetType().Name}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"TargetSite: {ex.TargetSite}");
    Console.WriteLine($"StackTrace: {ex.StackTrace}");
}
