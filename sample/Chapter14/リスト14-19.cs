// ■リスト14-19：インターフェイスからクラスを実装する（1）
class SleepyPet : IVirtualPet    // IVirtualPetインターフェイスを実装したクラスを定義
{
    public string Name { get; private set; }  // setはprivateに
    public int Mood { get; set; }
    public int Energy { get; set; }

    public SleepyPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }

    public void Eat()  // インターフェイスを実装する場合は、overrideキーワードは不要
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
}
