// ■リスト10-9：省略可能な引数を持つメソッドの呼び出し（1）
var person = new Person
{
    FirstName = "隆之",
    LastName = "森本"
};
var name1 = person.AddTitle("先生");  // ①引数を省略せず、"先生"を指定
var name2 = person.AddTitle();  // ②引数を省略して呼び出す
Console.WriteLine(name1);
Console.WriteLine(name2);
