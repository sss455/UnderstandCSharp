// ■リスト7-17：メソッドの途中でreturn文を使う
public string GetBodyType(double bmi)
{
    if (bmi < 18.5)
    {
        return "痩せ型";
    }
    if (bmi < 25)
    {
        return "普通体重";
    }
    if (bmi < 30)
    {
        return "肥満(1度)";
    }
    if (bmi < 35)
    {
        return "肥満(2度)";
    }
    if (bmi < 40)
    {
        return "肥満(3度)";
    }
    return "肥満(4度)";
}
