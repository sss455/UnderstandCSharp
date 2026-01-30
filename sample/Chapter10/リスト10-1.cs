// ■リスト10-1：配列を返すメソッド
static class ArrayUtils
{

    ……

    public static int[] GetArray(int count)  // int[]を指定して配列を返す静的メソッドを定義
    {
        var array = new int[count];
        for (var i = 0; i < count; i++)
        {
            var line = Console.ReadLine();
            array[i] = int.Parse(line);
        }
        return array;  // int型の配列を返す
    }
}
