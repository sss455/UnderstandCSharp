// ■リスト4-8：switch文の例（整数型の値による多分岐処理）
Console.WriteLine("ご希望の時間帯の番号を選択してください。");
Console.WriteLine(" 1: 10時から12時");
Console.WriteLine(" 2: 13時から15時");
Console.WriteLine(" 3: 15時から18時");
var line = Console.ReadLine();
var value = int.Parse(line);

switch (value)  // valueの値で分岐する
{
    case 1:
        Console.WriteLine("10時から12時がご希望ですね。");
        break;
    case 2:
        Console.WriteLine("13時から15時がご希望ですね。");
        break;
    case 3:
        Console.WriteLine("15時から18時がご希望ですね。");
        break;
    default:
        Console.WriteLine("入力した値に誤りがあります。");
        break;
}
