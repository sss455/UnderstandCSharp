// ■リスト8-11：静的メソッドを利用する
var scores = new int[] { 55, 60, 45, 70, 85, 93, 68 };
var total = ArrayUtils.Total(scores);      // 静的メソッドの呼び出し
var average = ArrayUtils.Average(scores);  // 同上
Console.WriteLine($"合計:{total}, 平均:{average}");
