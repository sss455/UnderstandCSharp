// ■リスト8-12：静的クラスの定義
static class ArrayUtils  // staticキーワードで静的クラスにする
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
