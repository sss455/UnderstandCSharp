// ■リスト10-13：コンストラクターの定義（コンストラクターで初期状態を設定）
class VirtualPet
{
    // ペットの名前
    public string Name { get; set; }

    // ペットの機嫌を示す（値が大きいと機嫌が良い）
    public int Mood { get; set; }

    // ペットの元気度を示す（エネルギーの値で元気かどうかを判断）
    public int Energy { get; set; }

    // コンストラクターの定義
    public VirtualPet()  // コンストラクターの名前はクラス名と同じにする
    {
        Name = "エイミー";
        Mood = 5;
        Energy = 100;
    }
}
