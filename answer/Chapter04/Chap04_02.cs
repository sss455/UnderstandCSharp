using System;

namespace Chap04
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num < 0)
            {
                Console.WriteLine("負数です");
            }
            else if (num == 0)
            {
                Console.WriteLine("0です");
            }
            else
            {
                Console.WriteLine("正数です");
            }
        }
    }
}
