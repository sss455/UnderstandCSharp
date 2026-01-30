// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// 配列
int[] array1;
array1 = new int[] { 65, 54 };

var array2 = new int[2];
array1[0] = 65;
array1[1] = 54;

var scores1 = new int[] { 65, 54, 78, 96, 81 };
var scores2 = new [] { 65, 54, 78, 96, 81 };
int[] scores3 = { 65, 54, 78, 96, 81 };


// 2次元配列
int[,] array2d1 = new int[4, 3];
array2d1[0, 0] = 11;

var array2d2 = new int[4, 3];
array2d2[0, 0] = 12;


int[,] array2d3 =
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
        {10, 11, 12},
    };

var array2d4 = new int[,]
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
        {10, 11, 12},
    };

for(var row = 0; row < array2d4.GetLength(0); row++)
{
    for (var col = 0; row < array2d4.GetLength(1); col++)
    {
        Console.Write($"{array2d4[row, col]}");
    }
    Console.WriteLine();
}