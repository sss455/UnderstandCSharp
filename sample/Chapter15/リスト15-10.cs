// ■リスト15-10：int.TryParseで文字列をintに変換する
var line = Console.ReadLine();
if (int.TryParse(line, out var num))
{
    ……  // numには、変換された整数が入っている
    ……  // numを使った処理をここに書く
}
