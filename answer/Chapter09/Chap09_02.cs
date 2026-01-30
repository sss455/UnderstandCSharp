using System;

namespace Chap09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q2-1
            var days = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine($"{days}日あります。");

            // Q2-2
            var line = Console.ReadLine();
            var date = DateTime.Parse(line);
            var week = date.ToString("dddd");
            Console.WriteLine($"{week}です");
        }
    }
}
