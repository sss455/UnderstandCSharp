using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap14_01
{
    class Program
    {
        // Q1-2 
        static void Main(string[] args)
        {
            // Addメソッドを使わなくても、以下のように書けば初期化ができます。
            // 「12-1-2 リストを初期化する」を参照のこと
            var pets = new List<VirtualPet> 
            {
                new FoodiePet("エイミー"),
                new CheerfulPet("クー"),
                new SleepyPet("ライアン")
            };
            foreach (var pet in pets)
            {
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
        }
    }

    // Q1-1
    abstract class VirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }
        // コンストラクタ
        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void Sleep();
    }

    class FoodiePet : VirtualPet
    {
        public FoodiePet(string name) : base(name)
        {
        }

        public override void Eat()    // overrideを使って上書き定義
        {
            Mood += 3;
            Energy += 8;  // ここを変更
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public override void Play()     // overrideを使って上書き定義
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public override void Sleep()    // overrideを使って上書き定義
        {
            Mood -= 1;
            Energy += 3;  // ここを変更
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }
    }

    class CheerfulPet : VirtualPet 
    {
        public CheerfulPet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood += 0;   // 値が変化しないことを明示する
            Energy += 5;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }

        public override void Play()
        {
            Mood += 3;
            Energy -= 12;  // ここを変更
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood -= 1;
            Energy += 4;  // ここを変更
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }
    }

    class SleepyPet : VirtualPet
    {
        public SleepyPet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public override void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood += 2;
            Energy += 4;  // ここを変更
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
    }
}
