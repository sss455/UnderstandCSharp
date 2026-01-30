// ■リスト7-15：複数のメソッドを定義したクラス
class BmiCalculator
{
    public double GetBmi(double height, double weight)
    {
        var metersTall = height / 100.0;
        var bmi = weight / (metersTall * metersTall);
        return bmi;
    }

    public string GetBodyType(double bmi)
    {
        var type = "";
        if (bmi < 18.5)
        {
            type = "痩せ型";
        }
        else if (bmi < 25)
        {
            type = "普通体重";
        }
        else if (bmi < 30)
        {
            type = "肥満(1度)";
        }
        else if (bmi < 35)
        {
            type = "肥満(2度)";
        }
        else if (bmi < 40)
        {
            type = "肥満(3度)";
        }
        else
        {
            type = "肥満(4度)";
        }
        return type;
    }
}
