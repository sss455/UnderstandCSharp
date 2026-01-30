using System;

namespace Chap03
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var amount = int.Parse(line);
            var point = (int)(amount * 0.01) * 5;
            Console.WriteLine($"金額:{amount} ポイント:{point}");
        }
    }
}
