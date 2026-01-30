// ■リスト13-16：ToStringメソッドの呼び出し例（2）
var employee = new Employee()
{
    Number = 512,
    FirstName = "理沙",
    LastName = "石井",
    HireDate = new DateTime(2016, 4, 1)
};
var s = employee.ToString();  // Employee型にはToStringメソッドは定義されていないが……
Console.WriteLine(s);
