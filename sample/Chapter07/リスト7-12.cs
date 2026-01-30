// ■リスト7-12：引数のあるメソッドの定義
class BmiCalculator
{
    // 身長はcm単位で、体重はkg単位で渡してもらう
    public double GetBmi(int height, int weight)
    {
        var metersTall = height / 100.0;
        var bmi = weight / (metersTall * metersTall);
        return bmi;
    }
}
