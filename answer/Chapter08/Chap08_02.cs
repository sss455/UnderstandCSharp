using System;

namespace Chap08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q2-3
            var bmi = BmiCalculator.GetBmi(158, 45);
            var type = BmiCalculator.GetBodyType(bmi);
            Console.WriteLine($"あなたは「{type}」です。");
        }
    }

    // Q2-2 staticキーワードでBmiCalculatorを静的クラスにする
    static class BmiCalculator
    {
        // Q2-1 staticキーワードでGetBmiを静的メソッドにする
        public static double GetBmi(int height, int weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }

        // Q2-1 staticキーワードでGetBodyTypeを静的メソッドにする
        public static string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "痩せ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満(1度)";
            }
            else if (bmi < 35)
            {
                type = "肥満(2度)";
            }
            else if (bmi < 40)
            {
                type = "肥満(3度)";
            }
            else
            {
                type = "肥満(4度)";
            }
            return type;
        }
    }
}
