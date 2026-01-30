// ■リスト15-14：try-finallyによる後処理（return文あり）
private static void ReadSample()
{
    var file = new StreamReader("C:\temp\test.txt");
    try
    {
        while (file.EndOfStream == false)
        {
            var line = file.ReadLine();
            if (line == "")
            {
                return;  // 途中でメソッドから抜け出す
            }
            Console.WriteLine(line);
        }
    }
    finally  // tryブロック内でreturn文が実行されても、このブロックは実行される
    {
        file.Dispose();
    }
}
