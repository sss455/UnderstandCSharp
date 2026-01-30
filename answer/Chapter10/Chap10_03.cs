using System;

namespace Chap10_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var mypet = new VirtualPet("こてつ");
            Console.WriteLine($"Name: {mypet.Name}");
            Console.WriteLine($"Mood: {mypet.Mood}");
            Console.WriteLine($"Energy: {mypet.Energy}");
            for (var i = 0; i < 20; i++)
            {
                mypet.MoodUp();
            }
            Console.WriteLine($"Mood: {mypet.Mood}");
            for (var i = 0; i < 20; i++)
            {
                mypet.MoodDown();
            }
            Console.WriteLine($"Mood: {mypet.Mood}");

        }
    }

    class VirtualPet
    {
        // ペットの名前
        public string Name { get; set; }

        // ペットの機嫌を示す（値が大きいと機嫌が良い）
        public int Mood { get; private set; }

        // ペットの元気度を示す（エネルギーの値で元気かどうかを判断）
        public int Energy { get; set; }

        // コンストラクタの定義
        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void MoodUp()
        {
            if (Mood < 10)
            {
                Mood++;
            }
        }

        public void MoodDown()
        {
            if (Mood > 1)
            {
                Mood--;
            }
        }
    }
}
