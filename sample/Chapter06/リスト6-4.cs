// ■リスト6-4：for文の繰り返し処理に配列のLengthプロパティを使ったコード
var scores = new int[] { 65, 54, 78, 96, 81 };
var total = 0;
for (var i = 0; i < scores.Length; i++)  // これなら、配列の要素がいくつになっても対応できる
{
    total += scores[i];
}
var average = (double)total / scores.Length; // 平均を求めるときもLengthプロパティを使う
Console.WriteLine("平均点: {0}", average);
