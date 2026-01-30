// ■リスト13-8：基底クラスに定義したメソッドを派生クラスのオブジェクトから呼び出す
var employee = new Employee
{
    Number = 352,
    FirstName = "涼太",
    LastName = "田中",
    Email = "rtanaka@example.com",
    HireDate = new DateTime(2015, 10, 1)
};
employee.Print();  // Personクラスで定義したメソッドを呼び出す
