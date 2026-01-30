// ■リスト10-12：最初に考えたクラス（プロパティのみ）
class VirtualPet
{
    // ペットの名前
    public string Name { get; set; }

    // ペットの機嫌を示す（値が大きいと機嫌が良い）
    public int Mood { get; set; }

    // ペットの元気度を示す（エネルギーの値で元気かどうかを判断）
    public int Energy { get; set; }
}
