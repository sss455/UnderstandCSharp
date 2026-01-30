// ■リスト10-15：引数のあるコンストラクター
class VirtualPet
{
    // ペットの名前
    public string Name { get; set; }
    // ペットの機嫌を示す（値が大きいと機嫌が良い）
    public int Mood { get; set; }
    // ペットの元気度を示す（エネルギーの値で元気かどうかを判断）
    public int Energy { get; set; }

    // コンストラクターの定義
    public VirtualPet(string name)  // コンストラクターにも引数を指定できる
    {
        Name = name;  // 仮引数nameがNameプロパティに代入される
        Mood = 5;
        Energy = 100;
    }
}
