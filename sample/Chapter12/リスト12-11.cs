// ■リスト12-11：LINQを使ってリストを操作する
using System;
using System.Collections.Generic;  // List<T>を使うのに必要
using System.Linq;  // LINQを使うのに必要

namespace Example
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int> { 12, 56, 75, 8, 12, 95, 32, 85, 24, 49 };
            var query = nums.Where(x => x >= 50);  // WhereはLINQが用意するメソッド
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
