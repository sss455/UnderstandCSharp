// ■リスト11-8：値型と参照型の違い（値型の場合）
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
    Club, Spade, Heart, Diamond  // 識別子は、このように1行に書くこともできる
}

struct Card
{
    public CardSuit Suit { get; set; }  // 確認のため、読み書き可能なプロパティに変更
    public int Number { get; set; }     // 確認のため、読み書き可能なプロパティに変更

    public Card(CardSuit suit, int number)
    {
        Suit = suit;
        Number = number;
    }
}
