using System;

namespace Chap03
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 100;               // int
            var n2 = 13;                // int
            var a1 = n1 + n2;           // int
            var a2 = -n1 / n2;          // int
            var a3 = (double)n1 / n2;   // double
            var a4 = a2 - n1;           // int
            var a5 = a3 * -2;           // double
            var a6 = a4 * 2.0M;         // decimal

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
        }
    }
}
