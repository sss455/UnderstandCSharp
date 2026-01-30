using System;

namespace Chap06
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[8];
            for (var i = 0; i < nums.Length; i++)
            {
                var line = Console.ReadLine();
                var num = int.Parse(line);
                nums[i] = num;
            }
            var total = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            var average = (double)total / nums.Length;
            Console.WriteLine($"合計: {total}");
            Console.WriteLine($"平均: {average}");
        }
    }
}
