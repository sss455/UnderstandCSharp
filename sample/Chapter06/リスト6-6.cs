// ■リスト6-6：foreach文で配列の各要素にアクセスする（1）
var scores = new int[] { 65, 54, 78, 96, 81 };
var total = 0;
foreach (var p in scores)  // foreachで配列の要素を1つずつ取り出す。pはint型
{
    total += p;  // 取り出した要素をtotalに足し込む
}
var average = (double)total / scores.Length;
Console.WriteLine("平均点: {0}", average);
