// ■リスト6-2：配列を使った例
var scores = new int[] { 65, 54, 78, 96, 81 };
var total = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];
var average = (double)total / 5;
Console.WriteLine("平均点: {0}", average);
