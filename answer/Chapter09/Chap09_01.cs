using System;

namespace Chap09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
        }
        
        // Q1-1
        private static void Ex1()
        {
            var line1 = Console.ReadLine();
            var n1 = double.Parse(line1);
            var line2 = Console.ReadLine();
            var n2 = double.Parse(line2);
            var min = Math.Min(n1, n2);
            Console.WriteLine($"小さい値は、{min} です");
        }

        // Q1-2
        private static void Ex2()
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "")
                { 
                    break;
                }
                var n = double.Parse(line);
                var floor = Math.Floor(n);
                var ceil = Math.Ceiling(n);
                Console.WriteLine($"切り捨て: {floor}, 切り上げ: {ceil}");
            }
        }
    }
}
