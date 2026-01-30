// ■リスト7-11：メソッドから戻り値を得る
class Program
{
    static void Main()
    {
        var sale = new Sale
        {
            ProductName = "おにぎり",
            UnitPrice = 120,
            Quantity = 4
        };
        var amount = sale.GetAmount();  // メソッドを呼び出し、その戻り値を受け取る
        Console.WriteLine($"合計金額:{amount}円");
    }
}

class Sale
{
    public string ProductName { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }

    public int GetAmount()  // 戻り値のあるメソッドの定義
    {
        return UnitPrice * Quantity;
    }
}
