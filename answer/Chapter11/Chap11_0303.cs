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
        }

        private static void ChangeToAce(Card card)
        {
            card = new Card(CardSuit.Club, 1);         
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

/*
 * ChangeToAceで、引数に渡ってくるcardは、MainメソッドのCardオブジェクトを複製したもの。
 * そのため、ChangeToAceで、card変数そのものを変更しても、MainメソッドのCardオブジェクトには
 * 影響はない
 */
