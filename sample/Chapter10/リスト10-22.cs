// ■リスト10-22：読み取り専用プロパティ（1）
class Person
{
    // 名
    public string FirstName { get; set; }
    // 姓
    public string LastName { get; set; }
    // 姓名
    public string FullName  // getアクセサーだけを持ったプロパティ
    {
        get { return LastName + FirstName; }
    }
}
