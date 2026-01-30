// ■リスト15-6：【×】コンパイルエラーになる例外処理
try
{
    ……
}
catch (System.Exception)
{
    Console.WriteLine("予期しないエラーが発生しました");
}
catch (System.DivideByZeroException)
{
    Console.WriteLine("ゼロは入力できません");
}
catch (System.FormatException)
{
    Console.WriteLine("数値を入力してください");
}
