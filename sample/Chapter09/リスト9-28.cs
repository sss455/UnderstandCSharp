// ■リスト9-28：テキストファイルを読み込む
var lines = File.ReadAllLines(@"C:\temp\祇園精舎.txt");
foreach (var line in lines)
{
    Console.WriteLine(line);
}
