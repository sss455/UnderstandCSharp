using System;

namespace Chap11_03
{
    class Program
    {
        static void Main()
        {
            var king = new Card(CardSuit.Spade, 13);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            ChangeToAce(king);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            /* 結果　値型では呼び出し元のオブジェクトの値は変更されない
             Suit:Spade, Number:13
             Suit:Spade, Number:13
            */
        }

        private static void ChangeToAce(Card card)
        {
            card.Number = 1;
            card.Suit = CardSuit.Diamond;
        }
    }

    enum CardSuit
    {
        Club, Spade, Heart, Diamond
    }

    struct Card
    {
        public CardSuit Suit { get; set; }
        public int Number { get; set; }

        public Card(CardSuit suit, int number)
        {
            Suit = suit;
            Number = number;
        }
    }

}
