// ■リスト8-10：静的メソッドだけを持つクラス
class ArrayUtils
{
    // 配列内の数値の合計を求める
    public static int Total(int[] numbers)
    {
        var total = 0;
        foreach (var n in numbers)
        {
            total += n;
        }
        return total;
    }

    // 配列内の数値の平均を求める
    public static double Average(int[] numbers)
    {
        var total = Total(numbers);  // 上記のTotalメソッドを呼び出す
        return (double)total / numbers.Length;
    }
}
