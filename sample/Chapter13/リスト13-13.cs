// ■リスト13-13：派生クラスのオブジェクトを基底クラスのリストに代入する
var persons = new List<Person>();
persons.Add(new Employee { …… });  // Person型のリストにEmployeeオブジェクトを格納
persons.Add(new Employee { …… });  // 同上
persons.Add(new Employee { …… });  // 同上
