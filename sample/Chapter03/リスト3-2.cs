// ■リスト3-2：同じ型による算術演算
var price1 = 1100;
var price2 = 800;
var price3 = 1250;
var total = price1 + price2 + price3;  // int型同士の加算の結果はint型
Console.WriteLine("合計: {0}円", total);

var member = 4;
var perPerson = total / member;  // int型同士の割り算の結果はint型
Console.WriteLine("1人当たり: {0}円", perPerson);

var remainder = total % member;  // int型同士の割り算の余りもint型
Console.WriteLine("余り: {0}", remainder);
