// ■リスト12-29：Anyメソッドを使ったコード
var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var any = nums.Any(x => x < 0);  // マイナス値があるか調べる
Console.WriteLine(any);
