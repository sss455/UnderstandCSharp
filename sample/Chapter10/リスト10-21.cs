// ■リスト10-21：プロパティに動作を加える（STEP 2）
class Book
{
    ……
    int _rating;

    public int Rating
    {
        get
        {
            return _rating;
        }
        set  // getアクセサー、setアクセサー内は、メソッドと同様複数行の処理が書ける
        {
            if (value <= 1)  // 1以下の値はすべて1をセット
            {
                 _rating = 1;
            }
            else if (value >= 6)  // 6以上の値はすべて5をセット
            {
                _rating = 5;
            }
            else
            {
                _rating = value;
            }
        }
    }
    ……
}
