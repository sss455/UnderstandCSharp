using System;
using System.Linq;

namespace Chap08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1-3 Max, Minを確認するコード
            var nums = new int[] { 5, 10, 8, 7, 21, -5, 14, -3 };
            var max = ArrayUtils.Max(nums);
            Console.WriteLine(max);
            var min = ArrayUtils.Min(nums);
            Console.WriteLine(min);
        }
    }

    static class ArrayUtils
    {
        // 配列内の数値の合計を求める
        public static int Total(int[] numbers)
        {
            int total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }
            return total;
        }

        // 配列内の数値の平均を求める
        public static double Average(int[] numbers)
        {
            var total = Total(numbers);
            return (double)total / numbers.Length;
        }

        // Q1-1 Maxメソッド
        public static double Max(int[] numbers)
        {
            // 必ず一つは要素はあるので、まず、最初の値を最大値とする
            int max = numbers[0];
            foreach (var n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }

        // Q1-2 Minメソッド
        public static double Min(int[] numbers)
        {
            // 必ず一つは要素はあるので、まず、最初の値を最小値とする
            int min = numbers[0];
            foreach (var n in numbers)
            {
                if (n < min)
                {
                    min = n;
                }
            }
            return min;
        }
    }
}
