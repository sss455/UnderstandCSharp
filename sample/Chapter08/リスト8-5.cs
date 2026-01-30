// ■リスト8-5：【×】1868年から2030年までのうるう年を出力するつもりのコード（1）
for (var year = 1868; year <= 2030; year++)
{
    var date = new DateTime(year, 1, 1);  // DateTimeに渡している1月1日には意味がない
    if (date.IsLeapYear())
    {
        Console.WriteLine(year);
    }
}
