// ■リスト15-13：try-finallyによる後処理
static void Main(string[] args)
{
    try
    {
        ReadSample();
    }
    catch
    {
        Console.WriteLine("ReadSampleでエラーが発生");
    }
}

private static void ReadSample()
{
    var file = new StreamReader("C:\temp\test.txt");
    try
    {
        while (file.EndOfStream == false)
        {
            var line = file.ReadLine();
            Console.WriteLine(line);
        }
    }
    finally
    {
        file.Dispose();  // 必ずDisposeメソッドが最後に呼ばれる
    }
}
