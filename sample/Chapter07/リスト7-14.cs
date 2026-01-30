// ■リスト7-14：メソッドの実引数に変数を渡す
var bmicalc = new BmiCalculator();
var h = 162;
var w = 63;
var bmi = bmicalc.GetBmi(h, w);  // 変数の値がメソッドに渡る
Console.WriteLine("{0:.00}", bmi);
