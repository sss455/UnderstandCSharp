// ■リスト10-4：クラスのオブジェクトを返すメソッドを呼び出す
static void Main(string[] args)
{
    var book1 = MakeBookObject();
    var book2 = MakeBookObject();
    book1.Print();
    book2.Print();
}
