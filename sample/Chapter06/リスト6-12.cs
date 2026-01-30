// ■リスト6-12：2次元配列でforeachを使う
var array2d = new int[,]
{
    {1, 2, 3},
    {4, 5, 6}
};
foreach (var item in array2d)
{
    Console.Write("{0} ", item);
}
Console.WriteLine();
