// ■リスト6-5：配列要素に値を設定する
// 10個の数値を配列に格納
var scores = new int[10];  // 10個の要素が入る配列を用意
for (var i = 0; i < scores.Length; i++)
{
    var line = Console.ReadLine();  // コマンドプロンプトの画面から文字列を入力
    var number = int.Parse(line);  // 文字列を数値に変換する（⇒p.96）
    scores[i] = number;  // 変換した数値を配列に格納
}
// 配列に格納された10個の数値の合計を求める
var total = 0;
for (var i = 0; i < scores.Length; i++)
{
    total += scores[i];
}
Console.WriteLine("合計: {0}", total);
