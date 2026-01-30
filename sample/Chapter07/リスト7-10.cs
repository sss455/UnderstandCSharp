// ■リスト7-10：戻り値のあるメソッドの定義
class Sale
{
    public string ProductName { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }

    public int GetAmount()  // 戻り値のあるメソッドの定義
    {
        var amount = UnitPrice * Quantity;
        return amount;  // amountの値が呼び出し元に返る
    }
}
