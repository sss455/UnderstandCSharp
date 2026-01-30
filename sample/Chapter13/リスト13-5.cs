// ■リスト13-5：派生クラスを利用する
var employee = new Employee
{
    Number = 352,
    FirstName = "涼太",  // FirstNameとLastNameはPersonクラスで定義したプロパティ
    LastName = "田中",
    HireDate = new DateTime(2015, 10, 1)
};
Console.WriteLine("従業員番号{0}の{1}は、{2}年に入社しました。",
    employee.Number, employee.FullName, employee.HireDate.Year);
