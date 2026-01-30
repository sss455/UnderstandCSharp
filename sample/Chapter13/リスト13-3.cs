// ■リスト13-3：派生クラスの定義（1）
// 従業員クラス
class Employee : Person  // Personクラスを継承してEmployeeクラスを定義
{
    // 従業員番号
    public int Number { get; set; }
    // 入社年月日
    public DateTime HireDate { get; set; }
}
