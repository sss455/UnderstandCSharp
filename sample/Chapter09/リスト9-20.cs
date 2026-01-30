// ■リスト9-20：小数部を四捨五入する
var r1 = Math.Round(6.4, MidpointRounding.AwayFromZero);  // 四捨五入
var r2 = Math.Round(6.4);  // 偶数丸め
Console.WriteLine($"{r1}, {r2}");
var r3 = Math.Round(6.5, MidpointRounding.AwayFromZero);  // 四捨五入
var r4 = Math.Round(6.5);  // 偶数丸め
Console.WriteLine($"{r3}, {r4}");
var r5 = Math.Round(6.6, MidpointRounding.AwayFromZero);  // 四捨五入
var r6 = Math.Round(6.6);  // 偶数丸め
Console.WriteLine($"{r5}, {r6}");
