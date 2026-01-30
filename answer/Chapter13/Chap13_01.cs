using System;

namespace Chap13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1-2 オブジェクトの初期化で、Birthdayに値を設定する
            var employee = new Employee
            {
                FirstName = "佳織",
                LastName = "本宮",
                Birthday = new DateTime(2001, 5, 8)
            };
            var customer = new Customer
            {
                FirstName = "翔太",
                LastName = "市村",
                Birthday = new DateTime(1998, 11, 18)
            };
            // Birthdayに値を取り出す
            Console.WriteLine($"{employee.FullName} {employee.Birthday}");
            Console.WriteLine($"{customer.FullName} {customer.Birthday}");
        }
    }

    // Q1-1 
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return LastName + FirstName; }
        }

        public string EMail { get; set; }

        // Birthdayを追加
        public DateTime Birthday { get; set; }
    }

    // 従業員クラス
    class Employee : Person
    {
        // 従業員番号
        public int Number { get; set; }
        // 入社年月日
        public DateTime HireDate { get; set; }

        public override string ToString()    // ToStringメソッドをオーバーライド
        {
            var s = $"{Number} {FullName} " +
                    $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
            return s;
        }
    }

    class Customer : Person    
    {
        // 顧客ID
        public string Id { get; set; }
        // 顧客ランク 1～5  5が最上ランク
        public int Rank { get; set; }
        // クレジットカード番号
        public string CreditCardNumber { get; set; }
    }

}