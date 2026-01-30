// ■リスト13-18：オーバーライドしたToStringメソッドを呼び出す（リスト13-16再掲）
var employee = new Employee()
{
    Number = 512,
    FirstName = "理沙",
    LastName = "石井",
    HireDate = new DateTime(2016, 4, 1)
};
var s = employee.ToString();  // オーバーライドしたToStringメソッドを呼び出す
Console.WriteLine(s);
