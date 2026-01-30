// ■リスト11-1：構造体を定義する
// Card構造体
struct Card  // structキーワードで構造体を定義
{
    // プロパティ
    public char Suit { get; private set; }   // 読み取り専用プロパティ
    public int Number { get; private set; }  // 読み取り専用プロパティ

    // コンストラクター
    public Card(char suit, int number)
    {
        Suit = suit;  // コンストラクターでSuitとNumberの値を初期化
        Number = number;
    }

    // メソッド
    public void Print()  // 構造体にもメソッドを定義できる
    {
        var s = "";
        switch (Suit)
        {
            case 'H':
                s = "ハート";
                break;
            case 'D':
                s = "ダイヤ";
                break;
            case 'S':
                s = "スペード";
                break;
            case 'C':
                s = "クラブ";
                break;
        }
        Console.WriteLine($"{s} {Number}");
    }
}
