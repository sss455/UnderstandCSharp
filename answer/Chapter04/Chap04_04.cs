using System;

namespace Chap04
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var term = "";
            switch (word)       
            {
                case "API":
                    term = "Application Programming Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
                case "IDE":
                    term = "Integrated Development Environment";
                    break;
                case "HTML":
                    term = "HyperText Markup Language";
                    break;
            }
            if (term != "")
            {
                Console.WriteLine("{0}は {1} の略です。", word, term);
            }
        }
    }
}
