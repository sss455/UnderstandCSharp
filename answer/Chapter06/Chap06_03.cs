using System;

namespace Chap06
{
    class Program
    {
        static void Main(string[] args)
        {
            // ここでは、7つの要素を持つ配列を用意
            string[] names = { "C#", "Ruby", "Kotlin", "Swift", "Python", "Java", "PHP" };
            var max = "";
            foreach (var name in names)
            {
                if (name.Length >= max.Length)
                {
                    max = name;
                }    
            }
            Console.WriteLine(max);
        }
    }
}
