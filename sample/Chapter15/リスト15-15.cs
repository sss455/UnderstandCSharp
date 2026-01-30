// ■リスト15-15：【×】後処理が正しく行われないコード
private static void ReadSample()
{
    var file = new StreamReader("C:\temp\test.txt");
    while (file.EndOfStream == false)
    {
        var line = file.ReadLine();
        if (line == "")
        {
            return;  // return文が実行されると途中でメソッドから抜け出す
        }
        Console.WriteLine(line);
    }
    file.Dispose();  // Disposeが呼ばれない場合がある
}
