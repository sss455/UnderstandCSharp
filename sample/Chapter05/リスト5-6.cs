// ■リスト5-6：do-while文の例（⇒図5-6）
var line = "";
do  // doブロックの中が繰り返す処理、最低1回は実行される
{
    Console.WriteLine("何か入力してください");
    line = Console.ReadLine();
} while (line == "");  // doブロックの処理が終わったら、繰り返しの条件チェックを行う
Console.WriteLine(line);
