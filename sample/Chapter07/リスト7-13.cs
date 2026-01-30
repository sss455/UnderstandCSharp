// ■リスト7-13：引数のあるメソッドの呼び出し
var bmicalc = new BmiCalculator();
var bmi = bmicalc.GetBmi(176, 67);  // 実引数を指定してメソッドを呼び出す
Console.WriteLine("{0:.00}", bmi);
