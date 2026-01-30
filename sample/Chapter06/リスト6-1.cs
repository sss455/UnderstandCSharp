// ■リスト6-1：【×】配列を使わない例
int score1 = 65;
int score2 = 54;
int score3 = 78;
int score4 = 96;
int score5 = 81;
var total = score1 + score2 + score3 + score4 + score5;
var average = (double)total / 5;
Console.WriteLine("平均点: {0}", average);
