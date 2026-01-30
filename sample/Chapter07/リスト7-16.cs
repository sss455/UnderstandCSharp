// ■リスト7-16：複数のメソッドの呼び出し
var bmicalc = new BmiCalculator();
var bmi = bmicalc.GetBmi(158, 45);
var type = bmicalc.GetBodyType(bmi);
Console.WriteLine($"あなたは「{type}」です。");
