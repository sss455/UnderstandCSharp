using System;

namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var count = int.Parse(line);
            for (var n = 0; n < count; n++)
            {
                var star = "*";
                for (var i = 0; i < n; i++)
                {
                    star += '*';
                }
                Console.WriteLine(star);
            }
        }
    }
}
