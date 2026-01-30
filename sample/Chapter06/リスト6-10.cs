// ■リスト6-10：for文で2次元配列にアクセスする
var array2d = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
    {10, 11, 12}
};
for (var row = 0; row < 4; row++)  // 4行分繰り返す
{
    for (var col = 0; col < 3; col++)  // 1行につき3列分繰り返す
    {
        Console.Write("{0} ", array2d[row, col]);  // 2次元配列にアクセスする
    }
    Console.WriteLine();  // ()のみのWriteLineは改行だけ行う
}
