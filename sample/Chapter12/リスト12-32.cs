// ■リスト12-32：ToListメソッドを使ったコード
var nums = new int[] { 12, 56, 75, 8, 12, 95, 32, 85, 24, 49 };
var list = nums.Where(x => x <= 10)
               .ToList();              // Whereの結果をList<int>に変換する
Console.WriteLine(list[0]);
