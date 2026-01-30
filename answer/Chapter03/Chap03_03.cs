using System;

namespace Chap03
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var a = 5;
            var b = 3;
            var n = 2;
            var k = 1;

            x /= 2;
            a += b * 2;
            n *= k + 4;

            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(n);
        }
    }
}
