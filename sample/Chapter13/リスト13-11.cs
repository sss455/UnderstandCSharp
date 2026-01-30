// ■リスト13-11：【×】誤った継承
class Customer : Employee  // CustomerはEmployeeではないから、これは誤った継承
{
    // 顧客ランク 1～5  5が最上ランク
    public int Rank { get; set; }
    // クレジットカード番号
    public string CreditCardNumber { get; set; }
}
