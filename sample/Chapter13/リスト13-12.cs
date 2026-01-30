// ■リスト13-12：派生クラスのオブジェクトを基底クラスの変数に代入する
Person person = new Employee  // Employee型のオブジェクトをPerson型の変数に代入
{
    Number = 352,
    FirstName = "涼太",
    LastName = "田中",
    HireDate = new DateTime(2015, 10, 1)
};
