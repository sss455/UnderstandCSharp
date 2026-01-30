// ■リスト7-1：クラスの定義
using System;
……

namespace ClassSample
{
    class Program  // Visual Studioで自動生成されたクラス。Bookクラスを呼び出す（利用する）クラス
    {
        static void Main(string[] args)
        {
            ……  // ここにBookクラスを利用するコードを書く
        }
    }

    class Book  // Bookクラスの定義
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
    }
}
