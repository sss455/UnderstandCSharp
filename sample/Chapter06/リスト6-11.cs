// ■リスト6-11：for文で2次元配列にアクセスする（GetLengthを使用）
var array2d = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
    {10, 11, 12}
};
for (var row = 0; row < array2d.GetLength(0); row++)
{
    for (var col = 0; col < array2d.GetLength(1); col++)
    {
        Console.Write("{0} ", array2d[row, col]);
    }
    Console.WriteLine();
}
