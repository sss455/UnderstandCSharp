using System;

namespace Chap04 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num < 0 || 100 < num) 
            {
                Console.WriteLine("入力した数値に誤りがあります");
                return;
            }
            if (num <= 30) 
            {
                Console.WriteLine("不可");
            } 
            else if (num <= 60) 
            {
                Console.WriteLine("可");
            } 
            else if (num <= 80) 
            {
                Console.WriteLine("良");
            } 
            else if (num <= 100) 
            {
                Console.WriteLine("優");
            }
        }
    }
}
