// ■リスト11-9：値型と参照型の違い（参照型の場合）
class Program
{
    static void Main()
    {
        var cardA = new Card(CardSuit.Spade, 4);
        var cardB = cardA;  // cardAをcardBに代入（コピー）
        cardA.Number = 12;  // cardAの番号を変更
        Console.WriteLine($"CardA: Suit:{cardA.Suit}, Number:{cardA.Number}");
        Console.WriteLine($"CardB: Suit:{cardB.Suit}, Number:{cardB.Number}");
    }
}

enum CardSuit
{
    Club, Spade, Heart, Diamond
}

class Card  // 構造体（値型）をクラス（参照型）に変えて動作を確認してみる
{
    public CardSuit Suit { get; set; }
    public int Number { get; set; }

    public Card(CardSuit suit, int number)
    {
        Suit = suit;
        Number = number;
    }
}
