// ■リスト11-6：列挙型をプロパティに持つ構造体
// CardSuit列挙型の定義
enum CardSuit
{
    Club,
    Spade,
    Heart,
    Diamond
}

// Card構造体の定義
struct Card
{
    public CardSuit Suit { get; private set; }  // SuitはCardSuit型のプロパティ
    public int Number { get; private set; }

    public Card(CardSuit suit, int number)  // 第1引数ではCardSuit型を受け取る
    {
        Suit = suit;
        Number = number;
    }

    public void Print()
    {
        var s = "";
        switch (Suit)
        {
            case CardSuit.Heart:
                s = "ハート";
                break;
            case CardSuit.Diamond:
                s = "ダイヤ";
                break;
            case CardSuit.Spade:
                s = "スペード";
                break;
            case CardSuit.Club:
                s = "クラブ";
                break;
        }
        Console.WriteLine($"{s} {Number}");
    }
}
