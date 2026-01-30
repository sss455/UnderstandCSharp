// ■リスト15-8：例外をスローする
// 身長はcmで、体重はkgで指定する
public double GetBmi(double height, double weight)
{
    if (height < 60.0 || 250.0 < height)
    {
        throw new ArgumentException("heightの指定に誤りがあります"); // 例外をスローする
    }
    if (weight < 10.0 || 200.0 < weight)
    {
        throw new ArgumentException("weightの指定に誤りがあります");  // 例外をスローする
    }
    var metersTall = height / 100.0;
    var bmi = weight / (metersTall * metersTall);
    return bmi;
}
