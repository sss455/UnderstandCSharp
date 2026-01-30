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

    class Card
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
 * ChangeToAceで、引数に渡ってくるcardは、MainメソッドのCardオブジェクトの参照を複製したもの。
 * つまり、Mainメソッドのking変数と引数cardは同じオブジェクトをさしてはいるが、
 * この2つ（kingとcard)は、それぞれ別のものである。
 * 別の言い方をすれば、オブジェクトのアドレスをメモ用紙に書いて、ChangeToAceに渡している。
 * そのため、ChangeToAceで、card変数そのものを変更しても、メモ用紙に書かれているアドレスが
 * 書き換わるだけで、Mainメソッドのking変数は、元のCardオブジェクトを指したままである。
 */
