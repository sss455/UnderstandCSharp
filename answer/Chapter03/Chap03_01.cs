using System;

namespace Chap03
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var amount = int.Parse(line);
            var rate = 0.08;
            var tax = (int)(amount * rate);
            Console.WriteLine(tax);
        }
    }
}
