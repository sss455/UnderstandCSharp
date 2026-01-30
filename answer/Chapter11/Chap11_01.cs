using System;

namespace Chap11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("あなたの生年月日は：");
            var line = Console.ReadLine();
            var date = DateTime.Parse(line);
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("日曜日に生まれました");
            }
            else
            {
                Console.WriteLine("日曜日生まれではありません");

            }
        }
    }
}
