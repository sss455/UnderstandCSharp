using System;

namespace Chap06
{
    class Program
    {
        static void Main(string[] args)
        {
            var array2d = new string[,]
            {
                { "sun" , "日曜日" },
                { "mon" , "月曜日" },
                { "tue" , "火曜日" },
                { "wed" , "水曜日" },
                { "thu" , "木曜日" },
                { "fri" , "金曜日" },
                { "sat" , "土曜日" }
            };
            for (var row = 0; row < array2d.GetLength(0); row++)
            {
                Console.WriteLine($"{array2d[row, 1]} ({array2d[row, 0]})");
            }
        }
    }
}
