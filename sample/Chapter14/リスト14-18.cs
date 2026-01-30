// ■リスト14-18：インターフェイスの定義
interface IVirtualPet  // interfaceキーワードでインターフェイスを定義
{
    string Name { get; }  // getだけを定義
    int Mood { get; set; }
    int Energy { get; set; }
    void Eat();
    void Play();
    void Sleep();
}
