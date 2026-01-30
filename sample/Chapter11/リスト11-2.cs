// ■リスト11-2：構造体を利用する
var card = new Card('H', 8);  // 構造体もnew演算子でインスタンスを生成する
card.Print();
if (card.Suit == 'D')
{
    Console.WriteLine("ダイヤです");
}
else
{
    Console.WriteLine("ダイヤではありません");
}
