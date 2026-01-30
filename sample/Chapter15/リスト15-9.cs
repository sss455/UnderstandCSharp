// ■リスト15-9：スローした例外をキャッチする
try
{
    var bc = new BmiCalculator();
    var bmi = bc.GetBmi(1.57, 49.5);
    Console.WriteLine(bmi);
}
catch (ArgumentException ex)  // ArgumentExceptionだけをキャッチする
{
    Console.WriteLine(ex.Message);
}
