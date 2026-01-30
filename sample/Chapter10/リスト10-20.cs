// ■リスト10-20：プロパティに動作を加える（STEP 1）
class Book
{
    ……
    int _rating;  // フィールドの定義

    public int Rating  // プロパティの定義
    {
        get  // getアクセサーの定義
        {
            return _rating;  // 参照時にこのコードが実行される
        }
        set  // setアクセサーの定義
        {
            _rating = value;  // 代入時にこのコードが実行される
        }
    }
    ……
}
