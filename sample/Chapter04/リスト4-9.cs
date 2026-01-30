// ■リスト4-9：switch文の例（文字列の値による多分岐処理）
var word = Console.ReadLine();
var term = "";

switch (word)  // switch文は、文字列に対しても使える
{
    case "API":
        term = "Application Programming Interface";
        break;
    case "RDB":
        term = "Relational Database";
        break;
    case "UI":
        term = "User Interface";
        break;
}

if (term != "")
{
    Console.WriteLine("{0}は {1} の略です。", word, term);
}
