// ■リスト13-4：派生クラスの定義（2）
// 顧客クラス
class Customer : Person
{
    // 顧客ID
    public string Id { get; set; }
    // 顧客ランク 1～5  5が最上ランク
    public int Rank { get; set; }
    // クレジットカード番号
    public string CreditCardNumber { get; set; }
}
