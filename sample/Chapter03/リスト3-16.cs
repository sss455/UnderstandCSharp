// ■リスト3-16：String.Formatを使った文字列の組み立て
var season = '夏';
var temperature = 39;
var str = String.Format("今年の{0}の最高気温は、{1}度でした。", season, temperature);
Console.WriteLine(str);
