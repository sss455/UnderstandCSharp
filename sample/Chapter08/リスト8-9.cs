// ■リスト8-9：静的メソッドと静的プロパティを利用する
var book1 = new Book { Title = "伊豆の踊子", Author = "川端康成" };
book1.PrintTitle();
var book2 = new Book { Title = "走れメロス", Author = "太宰治" };
book2.PrintTitle();
var book3 = new Book { Title = "銀河鉄道の夜", Author = "宮沢賢治" };
book3.PrintTitle();
Book.ClearCount();
Console.WriteLine(Book.Count);
