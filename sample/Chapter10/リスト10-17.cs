// ■リスト10-17：コンストラクターのオーバーロード
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()  // 引数のないコンストラクターを定義
    {
        FirstName = "";
        LastName = "";
    }

    public Person(string firstName, string lastName) // コンストラクターをオーバーロードして、引数を渡せるようにする
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
