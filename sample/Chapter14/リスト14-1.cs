// ■リスト14-1：【△】1つのクラスですべてのペットを扱うVirtualPetクラス
class VirtualPet
{
    public string Name { get; private set; }
    // 機嫌を表す
    public int Mood { get; set; }
    // 元気度を表す
    public int Energy { get; set; }
    // ペットの性格 1:食いしん坊 2:快活 3:寝坊
    public int Type { get; set; }
    // コンストラクター
    public VirtualPet(string name, int type)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
        Type = type;
    }
}
