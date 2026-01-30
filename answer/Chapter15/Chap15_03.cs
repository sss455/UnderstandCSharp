using System;
using System.IO;

namespace Chap15_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex01();
            Ex02();
        }

        // Q3-1
        private static void Ex01()
        {
            var sw = new StreamWriter("sample1.txt");
            try
            {
                sw.WriteLine("吾輩は猫である。");
                sw.WriteLine("名前はまだ無い。");
                sw.WriteLine("どこで生れたかとんと見当がつかぬ。");
            }
            finally
            {
                sw.Dispose();
            }
        }

        // Q3-2
        private static void Ex02()
        {
            using (var sw = new StreamWriter("sample2.txt"))
            {
                sw.WriteLine("吾輩は猫である。");
                sw.WriteLine("名前はまだ無い。");
                sw.WriteLine("どこで生れたかとんと見当がつかぬ。");
            }
        }
    }
}
