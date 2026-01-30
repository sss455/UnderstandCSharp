// ■リスト8-6：【×】1868年から2030年までのうるう年を出力するつもりのコード（2）
for (var year = 1868; year <= 2030; year++)
{
    var date = new DateTime();  // 日時未定のDateTimeオブジェクトを生成
    if (date.IsLeapYear(year))
    {
        Console.WriteLine(year);
    }
}
