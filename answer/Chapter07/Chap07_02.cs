using System;

namespace Chap07_02
{
    class Program
    {
        // Q2-3 
        static void Main(string[] args)
        {
            // 一つ目のインスタンスを生成
            var emp1 = new Employee
            {
                Id = 500,
                FamilyName = "吉村",
                GivenName = "健太"
            };
            // 二つ目のインスタンスを生成
            var emp2 = new Employee
            {
                Id = 501,
                FamilyName = "岸本",
                GivenName = "結衣"
            };
            Console.WriteLine(emp1.GetFullName());
            Console.WriteLine(emp2.GetFullName());
        }
    }

    // Q2-1, Q2-2 で定義したEmployeeクラス
    class Employee
    {
        // 以下、Q2-1 の4つのプロパティ
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string EmailAddress { get; set; }

        // Q2-2 GetFullNameメソッド
        public string GetFullName()
        {
            return $"{FamilyName} {GivenName}";
        }
    }
}
