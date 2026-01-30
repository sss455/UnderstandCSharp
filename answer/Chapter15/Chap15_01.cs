using System;

namespace Chap15_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex01();

            // 上記の行をコメントにすれば、このコードが動く
            Ex03();

        }

        // Q1-1
        private static void Ex01()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            // 例外が発生するコード　
            // Q1-2 System.IndexOutOfRangeException　例外が発生する。
            Console.WriteLine(array[5]);
        }

        // Q1-3
        private static void Ex03()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            // 例外をキャッチするコード

            try
            {
                Console.WriteLine(array[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
