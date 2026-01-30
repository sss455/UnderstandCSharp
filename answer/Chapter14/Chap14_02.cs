using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap14_02
{
    class Program
    {
        // Q2-2
        static void Main(string[] args)
        {
            // Addメソッドを使わなくても、以下のように書けば初期化ができます。
            // 「12-1-2 リストを初期化する」を参照のこと
            var pets = new List<IVirtualPet> 
            {
                new FoodiePet("エイミー"),
                new CheerfulPet("クー"),
                new SleepyPet("ライアン")
            };

            foreach (var pet in pets)  
            {
                pet.Eat();
                pet.Play();
                pet.Rest();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
        }
    }

    // Q2-1
    interface IVirtualPet
    {
        string Name { get; }
        int Mood { get; set; }
        int Energy { get; set; }
        void Eat();
        void Play();
        void Sleep();
        void Rest();
    }

    class SleepyPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }

        // 追加したメソッド
        public void Rest()
        {
            Mood += 1;
            Energy += 1;
            Console.WriteLine("SleepyPet.Restメソッドが実行されました");
        }
    }

    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public FoodiePet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }

        // 追加したメソッド
        public void Rest()
        {
            Mood += 1;
            Energy += 1;
            Console.WriteLine("FoodiePet.Restメソッドが実行されました");
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void Eat()
        {
            Mood += 0;
            Energy += 5;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood += 3;
            Energy -= 10;
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }

        // 追加したメソッド
        public void Rest()
        {
            Mood += 2;
            Energy += 2;
            Console.WriteLine("CheerfulPet.Restメソッドが実行されました");
        }
    }
}
