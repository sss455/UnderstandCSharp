using System;

namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxline = "";
            for (var i = 0; i < 10; i++)
            {
                var line = Console.ReadLine();
                var len = line.Length;
                if (len > maxline.Length)
                {
                    maxline = line;    // 最大長の文字列を覚えておく
                }
            }
            Console.WriteLine($"最大の長さの文字列は「{maxline}」です");
        }
    }
}
