// ■リスト3-9：異なる型での算術演算（リスト3-3再掲）
var total = 998;
var discount = total * 0.1;  // 割引額を求めている。結果は整数にしたいけど……
var payment = total - discount;

Console.WriteLine("割引額: {0}円", discount);
Console.WriteLine("支払額: {0}円", payment);
