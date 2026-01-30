using System;

namespace Chap11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q2で定義したPersonクラスの動作を確認するコード    
            var person = new Person("秀行", "出井", Gender.Male);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Gender);
        }
    }

    // Q2-1 Gender列挙型
    enum Gender
    {
        Male,
        Female
    }

    // Q2-2、Q2-3 後のPersonクラス
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get { return LastName + FirstName; }
        }

        // Q2-2 Gender列挙型のプロパティ
        public Gender Gender { get; set; }

        public Person()
        {
            FirstName = "";
            LastName = "";
        }

        // Q2-3 gender引数を追加したコンストラクター
        public Person(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}
