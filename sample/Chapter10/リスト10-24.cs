// ■リスト10-24：プロパティの初期化
class VirtualPet
{
    public string Name { get; private set; }
    public int Mood { get; set; } = 5;  // プロパティの値を5で初期化
    public int Energy { get; set; } = 100;  // プロパティの値を100で初期化

    // コンストラクター
    public VirtualPet(string name)
    {
        Name = name;
    }
}
