using System;

namespace Chap10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -20, 30, 50, 80, 20, -30 };
            Console.WriteLine(ArrayUtils.GetMin(nums, true));
            Console.WriteLine(ArrayUtils.GetMin(nums));
        }
    }

    static class ArrayUtils
    {

        public static int GetMin(int[] numbers, bool isPositive = false)
        {
            var min = int.MaxValue;
            foreach (var n in numbers)
            {
                if (isPositive && n <= 0)  // (isPositive == true && n <= 0) と書く必要はない
                {
                    continue;
                }
                min = Math.Min(min, n);
            }
            return min;
        }

    }
}
