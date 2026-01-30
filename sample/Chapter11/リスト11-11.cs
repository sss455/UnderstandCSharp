// ■リスト11-11：参照型をメソッドに渡したときの動作
class Program
{
    static void Main()
    {
        var king = new Card(CardSuit.Spade, 13);
        Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
        ChangeToAce(king);
        Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
    }

    private static void ChangeToAce(Card card)  // クラス（参照型）を引数で受け取る
    {
        card.Number = 1;
    }
}

enum CardSuit
{
    Club, Spade, Heart, Diamond
}

class Card  // class（参照型）に変えて動作を確認してみる
{
    public CardSuit Suit { get; set; }
    public int Number { get; set; }

    public Card(CardSuit suit, int number)
    {
        Suit = suit;
        Number = number;
    }
}
