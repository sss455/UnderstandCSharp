// ■リスト14-17：抽象メソッドを導入したVirtualPetクラス
abstract class VirtualPet
{
    public string Name { get; private set; }
    public int Mood { get; set; }
    public int Energy { get; set; }

    public VirtualPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }

    public abstract void Eat();    // abstractキーワードで抽象メソッドにする。メソッドの本体は書かない
    public abstract void Play();   // 同上
    public abstract void Sleep();  // 同上
}
