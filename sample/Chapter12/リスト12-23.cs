// ■リスト12-23：メソッドを連結させる（2）
var nums = new List<int> { 4, 6, 7, 1, 3, 9, 2, 1, 5, 8 };
var query = nums.OrderByDescending(x => x)  // 大きい順に並べ替え……
                .Take(3);  // 先頭の3つを取り出す
foreach (var n in query)
{
    Console.WriteLine(n);
}
