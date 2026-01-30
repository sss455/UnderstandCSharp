// ■リスト9-19：小数部を切り捨てる/切り上げる
var n = 3.7;
var floor = Math.Floor(n);  // 小数点以下を切り捨て
var ceiling = Math.Ceiling(n); // 小数点以下を切り上げ
Console.WriteLine($"{floor}, {ceiling}");
