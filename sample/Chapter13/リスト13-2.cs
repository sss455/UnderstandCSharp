// ■リスト13-2：基底クラスの定義
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get { return LastName + FirstName; }
    }
    public string Email { get; set; }
}
