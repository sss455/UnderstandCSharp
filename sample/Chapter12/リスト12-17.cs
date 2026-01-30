// ■リスト12-17：Selectメソッドを使ったコード（2）
var words = new List<string>
{
    "effect", "access", "condition", "sign", "profit", "line", "result"
};
var query = words.Select(x => x.Length);  // 各要素の長さを求める
foreach (var length in query)
{
    Console.WriteLine(length);
}
