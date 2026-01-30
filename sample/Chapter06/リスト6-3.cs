// ■リスト6-3：配列とfor文の繰り返し処理
var scores = new int[] { 65, 54, 78, 96, 81 };
var total = 0;  // totalの初期値は0
for (var i = 0; i < 5; i++)
{
    total += scores[i];  // 配列の0番目から4番目の要素を順に足している
}
var average = (double)total / 5;
Console.WriteLine("平均点: {0}", average);
