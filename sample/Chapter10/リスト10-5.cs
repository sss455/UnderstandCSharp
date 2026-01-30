// ■リスト10-5：メソッドのオーバーロード（多重定義）
static class ArrayUtils
{
    // ①int型の配列内の数値の合計を求める
    public static int Total(int[] numbers)
    {
        var total = 0;
        foreach (var n in numbers)
        {
            total += n;
        }
        return total;
    }

    // ②double型の配列内の数値の合計を求める
    public static double Total(double[] numbers)  // 同じメソッド名で引数だけが異なる
    {
        var total = 0.0;
        foreach (var n in numbers)
        {
            total += n;
        }
        return total;
    }

    ……
}
