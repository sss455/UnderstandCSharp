// ■リスト15-12：【×】後処理が万全ではないコード
using System;
using System.IO;

namespace Example
{
    class Program
    {
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
            var file = new StreamReader("C:\temp\test.txt");  // ファイルを読み込む準備
            while (file.EndOfStream == false)
            {
                var line = file.ReadLine();
                Console.WriteLine(line);
            }
            file.Dispose();  // StreamReaderの後処理。この後処理は実行されない可能性がある
        }
    }
}
