// ■リスト14-13：【×】継承を使わないFoodiePetクラス
class FoodiePet
{
    // 継承を使わないので、Name、Mood、Energyも定義
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
}
