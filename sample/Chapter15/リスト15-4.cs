// ■リスト15-4：例外の種類を指定して例外をキャッチする（1）
try
{
    var total = 1000;
    var line = Console.ReadLine();
    var count = int.Parse(line);
    var ans = total / count;
    Console.WriteLine(ans);
    Console.WriteLine("正常終了");
}
catch (System.DivideByZeroException)  // DivideByZeroException例外をキャッチする
{
    Console.WriteLine("ゼロは入力できません");
}
catch (System.FormatException)  // FormatException例外をキャッチする
{
    Console.WriteLine("数値を入力してください");
}
