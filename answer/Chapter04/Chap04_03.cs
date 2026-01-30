using System;

namespace Chap04
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("numは3でも5で割り切れます");
            }
        }
    }
}
