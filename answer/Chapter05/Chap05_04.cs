using System;

namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {

            var total = 0.0;
            while (true)
            {
                var line = Console.ReadLine();
                var num = double.Parse(line);
                if (num <= 0)
                { 
                    break;
                }
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}
