// ■リスト3-3：異なる型での算術演算
var total = 998;
var discount = total * 0.1;      // int型とdouble型の演算の結果はdouble型
var payment = total - discount;  // 同上

Console.WriteLine("割引額: {0}円", discount);
Console.WriteLine("支払額: {0}円", payment);
