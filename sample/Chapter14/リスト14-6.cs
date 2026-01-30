// ■リスト14-6：派生クラスのコンストラクターの定義（FoodiePetクラス）
class FoodiePet : VirtualPet
{
    public FoodiePet(string name) : base(name)  // baseキーワードで、継承元のコンストラクターを呼び出す
    {
    }

    ……
}
