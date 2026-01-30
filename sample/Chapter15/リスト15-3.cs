// ■リスト15-3：上位の呼び出し元でtry-catch構文を使う
try
{
    DoSomething();  // DoSomethingメソッド内で例外が発生するとcatchブロックが実行される
}
catch
{
    Console.WriteLine("エラーが発生しました");
}
