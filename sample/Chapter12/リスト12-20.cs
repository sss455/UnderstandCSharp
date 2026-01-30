// ■リスト12-20：OrderByメソッドを使ったコード（2）
var words = new List<string>
{
    "effect", "access", "condition", "sign", "profit", "line", "result"
};
var query = words.OrderBy(x => x);
foreach (var word in query)
{
    Console.WriteLine(word);
}
