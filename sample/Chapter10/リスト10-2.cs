// ■リスト10-2：配列を返すメソッドを呼び出す
var nums = ArrayUtils.GetArray(5);  // 変数numsの型はint[]
// nums配列内の要素の合計を求める
var total = 0;
foreach (var x in nums)
{
    total += x;
}
Console.WriteLine($"合計: {total}");
