// ■リスト12-31：ToArrayメソッドを使ったコード
var words = new List<string>
{
    "effect", "access", "condition", "sign", "profit", "line", "result"
};
var array = words.OrderBy(x => x)
                 .ToArray();  // OrderByの結果をstring[]に変換する
Console.WriteLine(array[0]);
