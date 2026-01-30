using System;

namespace Chap06
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[20];
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = 100 + i;
            }
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
        }

    }
}
