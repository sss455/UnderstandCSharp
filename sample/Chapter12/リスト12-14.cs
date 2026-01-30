// ■リスト12-14：文字列のコレクションに対してLINQを使う
var words = new List<string>
{
    "effect", "access", "condition", "sign", "profit", "line", "result"
};
var query = words.Where(x => x.Length == 6);  // 長さ6の文字列だけ取り出す
foreach (var word in query)
{
    Console.WriteLine(word);
}
