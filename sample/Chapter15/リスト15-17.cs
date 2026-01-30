// ■リスト15-17：using文による後処理
private static void ReadSample()
{
    using (var file = new StreamReader("C:\temp\test.txt"))
    {
        while (file.EndOfStream == false)
        {
            var line = file.ReadLine();
            Console.WriteLine(line);
        }
    }  // Disposeメソッドが書かれていないが、最後にfile.Disposeが呼ばれる
}
