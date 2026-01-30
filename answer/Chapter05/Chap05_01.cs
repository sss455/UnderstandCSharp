using System;

namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                var n = int.Parse(line);
                Console.WriteLine(n);
                if (n < 0)
                {
                    break;
                }    
            }
        }
    }
}
