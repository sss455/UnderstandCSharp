using System;

namespace Chap03
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 20;

            Console.WriteLine($"a={a} b={b}");

            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a={a} b={b}");
        }
    }
}
