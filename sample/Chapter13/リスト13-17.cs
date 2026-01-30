// ■リスト13-17：ToStringメソッドをオーバーライドする
// 従業員クラス
class Employee : Person
{
    // 従業員番号
    public int Number { get; set; }
    // 入社年月日
    public DateTime HireDate { get; set; }

    public override string ToString()  // ToStringメソッドをオーバーライド
    {
        var s = $"{Number} {FullName} " +
                $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
        return s;
    }
}
