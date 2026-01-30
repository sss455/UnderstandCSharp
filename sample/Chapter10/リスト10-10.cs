// ■リスト10-10：省略可能な引数を持つメソッドの定義（2）
static class ArrayUtils
{
    public static void SetValue(int[] array, int value = 0, int inc = 0)  // valueの省略値は0、incの省略値は0
    {
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = value;
            value += inc;
        }
    }

    ……
}
