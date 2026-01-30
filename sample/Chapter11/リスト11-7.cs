// ■リスト11-7：列挙型を利用する
var card = new Card(CardSuit.Heart, 8);
card.Print();
if (card.Suit == CardSuit.Diamond)
{
    Console.WriteLine("ダイヤです");
}
else
{
    Console.WriteLine("ダイヤではありません");
}
