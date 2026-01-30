// ■リスト10-23：読み取り専用プロパティ（2）
class VirtualPet
{
    public string Name { get; private set; }  // setの前にprivateを指定していることでgetだけが公開される。つまり、読み取り専用になる
    public int Mood { get; set; }
    public int Energy { get; set; }

    // コンストラクター
    public VirtualPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }
}
