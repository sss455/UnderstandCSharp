// ■リスト12-19：OrderByメソッドを使ったコード（1）
var nums = new List<int> { 4, 6, 7, 1, 3, 9, 2, 5, 8 };
var query = nums.OrderBy(x => x);  // 小さい順に並べ替える
foreach (var n in query)
{
    Console.WriteLine(n);
}
