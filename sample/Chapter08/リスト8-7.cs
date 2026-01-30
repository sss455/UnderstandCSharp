// ■リスト8-7：1868年から2030年までのうるう年を出力するコード
for (var year = 1868; year <= 2030; year++)
{
    if (DateTime.IsLeapYear(year))  // インスタンスを生成しないでメソッドを呼び出している
    {
        Console.WriteLine(year);
    }
}
