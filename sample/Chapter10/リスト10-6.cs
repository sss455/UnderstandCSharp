// ■リスト10-6：オーバーロードしたメソッドを呼び出す
var scores = new int[] { 55, 60, 45, 70, 85, 93, 68 };
var total = ArrayUtils.Total(scores);  // ①のTotalメソッドが呼ばれる
Console.WriteLine(total);

var scores2 = new double[] { 5.9, 9.6, 12.4, 8.0, 7.9 };
var total2 = ArrayUtils.Total(scores2);  // ②のTotalメソッドが呼ばれる
Console.WriteLine(total2);
