// ■リスト12-12：LINQを使って配列を操作する
var nums = new int[] { 12, 56, 75, 8, 12, 95, 32, 85, 24, 49 };
var query = nums.Where(x => x >= 50);  // 配列に対してもWhereメソッドが使える
foreach (var n in query)
{
    Console.WriteLine(n);
}
