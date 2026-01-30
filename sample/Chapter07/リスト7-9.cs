// ■リスト7-9：メソッドの呼び出し（2）
var book1 = new Book
{
    Title = "吾輩は猫である",
    Author = "夏目漱石",
    Pages = 610,
    Rating = 4
};
var book2 = new Book
{
    Title = "人間失格",
    Author = "太宰治",
    Pages = 212,
    Rating = 5
};
book1.Print();  // book1オブジェクトにPrintをお願いしている
book2.Print();  // book2オブジェクトにPrintをお願いしている
