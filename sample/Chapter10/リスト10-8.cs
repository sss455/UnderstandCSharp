// ■リスト10-8：省略可能な引数を持つメソッドの定義（1）
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string AddTitle(string title = "様")  // titleは省略可能な引数
    {
        return $"{LastName}{FirstName} {title}";
    }
}
