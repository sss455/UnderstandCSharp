using System;

namespace Chap15_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex01();
            Ex02();
        }

        // Q2-1
        private static void Ex01()
        {
            while (true)
            {
                try
                {
                    var total = 1000;
                    var line = Console.ReadLine();
                    var count = int.Parse(line);
                    var ans = total / count;
                    Console.WriteLine(ans);
                    Console.WriteLine("正常終了");
                    break;
                }
                catch
                {
                    Console.WriteLine("入力した値が正しくありません.再度入力してください");
                }
            }
        }

        // Q2-2
        private static void Ex02()
        {
            while (true)
            {
                var total = 1000;
                var line = Console.ReadLine();
                if (int.TryParse(line, out var count))
                {
                    if (count == 0)
                    {
                        Console.WriteLine("0は入力できません");
                    }
                    else
                    {
                        var ans = total / count;
                        Console.WriteLine(ans);
                        Console.WriteLine("正常終了");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("入力した値が正しくありません.再度入力してください");
                }
            }
        }
    }
}
