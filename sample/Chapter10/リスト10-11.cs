// ■リスト10-11：省略可能な引数を持つメソッドの呼び出し（2）
var array = new int[10];

// ①配列の要素を 0、10、20、30、40 …… に設定する
ArrayUtils.SetValue(array, 0, 10);

// ②配列のすべての要素を1に設定する
ArrayUtils.SetValue(array, 1);

// ③配列のすべての要素を0に設定する
ArrayUtils.SetValue(array);
