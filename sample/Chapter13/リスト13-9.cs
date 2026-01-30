// ■リスト13-9：派生クラスでメソッドをオーバーライド（上書き）する
class Person  // 基底クラス
{
    ……
    public virtual void Print()  // virtualキーワードを付けると派生クラスでオーバーライドできる
    {
        Console.WriteLine($"名前: {FullName} ({Email})");
    }
}

class Employee : Person  // 派生クラス
{
    ……
    public override void Print()  // overrideキーワードでメソッドを上書き定義
    {
        Console.WriteLine($"{Number}:{FullName} ({Email}) {HireDate.Year}年入社");
    }
}
