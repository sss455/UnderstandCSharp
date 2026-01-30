// ■リスト13-10：オーバーライドしたメソッドを呼び出す
class Program
{
    static void Main()
    {
        var person = new Person
        {
            FirstName = "はるか",
            LastName = "佐々木",
            Email = "hsasaki@example.com"
        };
        person.Print();  // PersonクラスのPrintメソッドを呼び出す

        var employee = new Employee
        {
            Number = 352,
            FirstName = "涼太",
            LastName = "田中",
            Email = "rtanaka@example.com",
            HireDate = new DateTime(2015, 10, 1)
        };
        employee.Print();  // オーバーライドしたEmployeeクラスのPrintメソッドを呼び出す
    }
}
