# 新・標準プログラマーズライブラリ なるほどなっとく C#入門

## 目次

## 第0章 C#プログラミングを始める前に
### 0-1 プログラミングとは？
### 0-2 機械語に翻訳するコンパイラー
### 0-3 統合開発環境で楽々開発
### 0-4 .NETという強力な助っ人
### 0-5 本書で扱うプログラムの種類

## 第1章 初めてのC#プログラミング
### 1-1 ようこそ、C#の世界へ
### 1-2 プロジェクトとソリューション
### 1-3 入力したプログラムを理解しよう
### 1-4 usingディレクティブを使って簡略化
### 1-5 デバッグ機能を使って実行順序を確かめてみよう
### 1-6 数値を扱ってみる
### 1-7 C#のコードを入力するうえでの注意点
### 1-8 作成したプログラムをコマンドプロンプトから実行する

## 第2章 変数と変数の型
### 2-1 変数とは？
### 2-2 変数の基本的な使い方
### 2-3 変数名の付け方
### 2-4 変数の型

## 第3章 演算と演算子
### 3-1 演算とは？ 演算子とは？
### 3-2 算術演算
### 3-3 単項演算子
### 3-4 代入演算子
### 3-5 数値の型変換
### 3-6 文字列の連結

## 第4章 条件に応じた処理
### 4-1 条件分岐処理の必要性
### 4-2 if文による条件分岐処理
### 4-3 関係演算子と論理演算子
### 4-4 switch文による多分岐処理
### 4-5 else if構文を使った多分岐処理

## 第5章 繰り返し処理
### 5-1 繰り返し処理とは？
### 5-2 while文（指定条件の間繰り返す処理）
### 5-3 for文（特に指定回数繰り返す処理）
### 5-4 do-while文（最低1回は実行される繰り返し処理）
### 5-5 2重ループ
### 5-6 break文
### 5-7 continue文
### 5-8 難しい2重ループのコードを読んでみよう

## 第6章 配列
### 6-1 配列の基礎
### 6-2 配列とfor文の繰り返し処理
### 6-3 初期化を伴わない配列の宣言
### 6-4 配列要素に値を設定する
### 6-5 foreach文を使った繰り返し処理
### 6-6 2次元配列

## 第7章 クラス/オブジェクト指向プログラミングの基礎
### 7-1 オブジェクト指向とは？
### 7-2 オブジェクト指向以前
### 7-3 初めてのクラス
### 7-4 クラスとオブジェクトの違い
### 7-5 メソッドを定義する
### 7-6 メソッドの利点
### 7-7 変数のスコープ

## 第8章 静的メソッド/静的プロパティ/静的クラス
### 8-1 staticとは何なのだろう？
### 8-2 インスタンスプロパティとインスタンスメソッド
### 8-3 静的メソッドと静的プロパティ
### 8-4 静的クラス

## 第9章 クラスを使いこなそう
### 9-1 名前空間
### 9-2 Stringクラスを使ってみる
### 9-3 Mathクラスを使ってみる
### 9-4 DateTime構造体を使ってみる
### 9-5 Fileクラスを使ってみる

## 第10章 クラスについて掘り下げる
### 10-1 メソッドはどんな型でも返せる
### 10-2 メソッドのオーバーロード（多重定義）
### 10-3 メソッドの省略可能な引数
### 10-4 コンストラクターを使いこなす
### 10-5 プロパティの高度な使い方

## 第11章 値型と参照型
### 11-1 構造体
### 11-2 列挙型
### 11-3 値型と参照型
### 11-4 参照先がないことを表すnull

## 第12章 リストクラスとLINQ
### 12-1 Listクラス
### 12-2 LINQを使ってみよう

## 第13章 継承
### 13-1 継承とは？
### 13-2 継承を利用しない場合
### 13-3 クラスを継承する
### 13-4 継承とis a関係
### 13-5 すべての型の頂点に立つobject型

## 第14章 ポリモーフィズム
### 14-1 ポリモーフィズムとは？
### 14-2 ポリモーフィズム以前
### 14-3 継承によるポリモーフィズムを導入する
### 14-4 継承するための抽象クラスと抽象メソッド
### 14-5 インターフェイスによるポリモーフィズム

## 第15章 エラーへの対応
### 15-1 例外とは？
### 15-2 例外をキャッチする
### 15-3 例外を発生させる
### 15-4 後始末が必要な場合の「後処理」

<br><br>
---
<br><br>

## 第1章 初めてのC#プログラミング
### 1-1 ようこそ、C#の世界へ
#### 1-1-3 ビルド処理をする

```
＜ビルド＞───────────────────────────────────────────────────────────┐
 │                                                                  │
 │　　         コンパイル                                            │
 │　　[ A.cs ] ⇒⇒⇒⇒⇒ [ A.obj ] ──┐   結合処理                    │
 │　　[ B.cs ] ⇒⇒⇒⇒⇒ [ B.obj ] ──├─ ⇒⇒⇒⇒⇒ [ Example.exe ]   │
 │　　[ C.cs ] ⇒⇒⇒⇒⇒ [ C.obj ] ──┘                              │
 │                                                                  │
 └──────────────────────────────────────────────────────────────────┘
```

<br>


### 1-8 作成したプログラムをコマンドプロンプトから実行する
#### 1-8-1 作成した実行ファイルの場所
`{プロジェクトルート}/bin/Debug/net10/*プロジェクト名*.exe`

<br>


## 第2章 変数と変数の型
### 2-2 変数の基本的な使い方
**＜C#のバージョンとVisual Studioのバージョンの対応表＞**
| C#のバージョン | Visual Studioのバージョン
|--|--
| C# 1.0 | Visual Studio 2002
| C# 2.0 | Visual Studio 2005
| C# 3.0 | Visual Studio 2008
| C# 4.0 | Visual Studio 2010
| C# 5.0 | Visual Studio 2012/2013
| C# 6.0 | Visual Studio 2015
| C# 7.0 | Visual Studio 2017
| C# 8.0 | Visual Studio 2019

C#のそれぞれのバージョンごとの特徴は[<u>こちら</u>](https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-version-history)

<br>

### 2-4 変数の型
**整数型：**<br>
　　たいていの場合、計算速度とサイズのバランスのとれた <font color="red">「int型」</font>を使っておけば問題ない。<br>
　　それ以外の整数型は特別な理由がある場合だけ利用する。<br>
**浮動小数点型：**<br>
　　特別な理由が無い限り、<font color="red">「doubule型」</font>を使うのが一般的。<br>
　　float型は、有効桁数も7桁と小さく、計算誤差も大きいため、使うことはほとんどない。<br>
**decimal型：**<br>
　　浮動小数点型との違いは、小数点以下の値を28桁まで正しく持つことができる点。<br>
　　そのため、decimal型は小数点が出てくる財務や金融の計算に適している<br>
　　`var average = 3.28m`<br>
　　数値の末尾に **"m"** が付くとdecimal型になる。このマークを **サフィックス(接尾辞)** と言う。

**＜サフィックスの種類＞**
| 型 | サフィックス | 例
|--|--|--
| uint    | U、u   | 123U&nbsp;&nbsp;、123u
| long    | L、l   | 256L&nbsp;&nbsp;、256l
| ulong   | UL、ul | 256UL、256ul
| float   | F、f   | 123.4F、123.4f
| double  | D、d   | 123.4D、123.4d
| decimal | M、m   | 123.4M、123.4m

<br>

## 第4章 条件に応じた処理
### 4-4 switch文による多分岐処理
**＜C#のバージョンと主な追加機能＞**

| バージョン | リリース年 | 主な追加機能
|--|--|--
| 1.0 | 2002 | `※一旦飛ばし(p.119参照)`
| 2.0 | 2005 | 
| 3.0 | 2007 | 
| 4.0 | 2010 | 
| 5.0 | 2012 | 
| 6.0 | 2015 | 
| 7.0 | 2017 | 
| 8.0 | 2019 | 


<br>

## 第6章 配列
### 6-1 配列の基礎
#### 6-1-3 配列の宣言と初期化
```
int[] array1;
array1 = new int[] { 65, 54 };

var array2 = new int[2];
array1[0] = 65;
array1[1] = 54;

var scores1 = new int[] { 65, 54, 78, 96, 81 };
var scores2 = new [] { 65, 54, 78, 96, 81 };
int[] scores3 = { 65, 54, 78, 96, 81 };
```
<br>

### 6-6 2次元配列
#### 6-6-1 初期化を伴わない宣言をする場合
```
int[,] array2d1 = new int[4, 3];
array2d1[0, 0] = 11;

var array2d2 = new int[4, 3];
array2d2[0, 0] = 12;

```

#### 6-6-1 配列の宣言と初期化を同時にする場合
```cs
int[,] array2d3 =
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
        {10, 11, 12},
    };

var array2d4 = new int[,]
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
        {10, 11, 12},
    };

for(var row = 0; row < array2d4.GetLength(0)★; row++)
{
    for (var col = 0; row < array2d4.GetLength(1)★; col++)
    {
        Console.Write($"{array2d4[row, col]}");
    }
    Console.WriteLine();
}
```
<br>


## 第7章 クラス/オブジェクト指向プログラミングの基礎
### 7-3 初めてのクラス
#### 7-3-1 クラスを定義する
 **◎プロパティの定義** 
 ```cs
public string Title { get; set; }
 ```
<br>

#### 7-3-3 オブジェクト初期化子を使ったオブジェクトの初期化
オブジェクト初期化子：インスタンスの生成とオブジェクトの初期化を同時に行う構文。
```cs
var book = new Book
    {
        Title  = "吾輩は猫である",
        Author = "夏目漱石",
        Pages  = 610,
        Rating = 4
    };

```
<br>


## 第9章 クラスを使いこなそう
### 9-1 名前空間
### 9-2 Stringクラスを使ってみる
### 9-3 Mathクラスを使ってみる
### 9-4 DateTime構造体を使ってみる
### 9-5 Fileクラスを使ってみる

| クラス | 使用法 | 説明 
|--|--|--
| String | var length = str.Length; | 文字数を取得
| 〃 | var sub1 = str1.Substring(0,6);<br>var sub2 = str1.Substring(6,2);<br>_ | 開始位置0から6文字分を取り出して返却する<br>開始位置6から2文字分を取り出して返却する<br>※オリジナルの文字列は変更されない
| 〃 | var str2 = str1.Trim(); | 文字列の前後の空白を除去する却する<br>※オリジナルの文字列は変更されない
| 〃 | var str2 = str1.ToUpper(); | 文字列内の英字をすべて<u>大文字</u>にする
| 〃 | var str2 = str1.ToLower(); | 文字列内の英字をすべて<u>小文字</u>にする
| 〃 | var str2 = str1.Replace("static", "静的"); | 指定した別の文字列に置き換える
| 〃 | if ( str.Contains("static") ) { ... } | 指定の文字列が存在するか調べる
| 〃 | string[] items = str1.Split( ',' ); | 指定した文字で、文字列を分割する
|  |  | 
| Math | var abs1 = Math.Abs( 150 );<br>var abs2 = Math.Abs( -320 ); | 結果：150<br>結果：320
| 〃 | var abs3 = Math.Abs( -5.67M );<br>var abs4 = Math.Abs( -1.414 ); | 結果：5.67　※decimal型<br>結果：1.414  ※double型
| 〃 | var big = Math.Max( 340, 500 ); | 結果：500 ※2つの数値のうち<u>大きいほう</u>を取得する
| 〃 | var small = Math.Min( 340, 500 ); | 結果：340 ※2つの数値のうち<u>小さいほう</u>を取得する
| 〃 | double num = Math.Floor( 3.7 ); | 結果：3 ※小数点以下を切り<u>捨て</u>
| 〃 | double num = Math.Ceiling( 3.7 ); | 結果：4 ※小数点以下を切り<u>上げ</u>
| 〃 | Math.Round | `...いったん飛ばし...`
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  | 
|  |  |  
<br>



## 第10章 クラスについて掘り下げる
### 10-3 メソッドの省略可能な引数
`public void AddTitle(string title = "吾輩は猫である");`
<br><br>


### 10-5 プロパティの高度な使い方
#### 10-5-1 プロパティに特別な動作を加える
**STEP 0**
```cs
// 自動実装プロパティ
public int Rating { get; set; }
```
<br>

**STEP 1**
```cs
// ※アクセス修飾子を省略した場合は、privateとなる。
int _rating;

public int Rating 
{ 
    get
    {
        return _rating;
    }
    set
    {
        // どこにも定義されていない valueという変数は、
        // 代入される値を示す特別なキーワード
        _rating = value;
    }
}
```
<br>

**STEP 2**
```cs
int _rating;

public int Rating 
{ 
    get
    {
        return _rating;
    }
    // get,setアクセサー内はメソッドと同様、複数行の処理が書ける
    set
    {
        if(value <= 1)       // 1以下の値はすべて1をセット
        {
            _rating = 1:
        }
        else if(value >= 6)  // 6以上の値はすべて5をセット
        {
            _rating = 5;
        }
        else
        {
            _rating = value;
        }
    }
}
```
<br>

#### 10-5-2 読み取り専用のプロパティ
△
```cs
定義側：
public string FirstName { get; set; }  // 名
public string LastName  { get; set; }  // 姓

// 姓名の取得メソッド★
public string GetFullName()
{
    return LastName + FirstName;
}
```
```cs
使う側：
var person = new Person
    {
        LastName  = "夏目",
        FirstName = "漱石"
    }
var name = person.GetFllName(); //★
```

◎
```cs
定義側：
public string FirstName { get; set; }  // 名
public string LastName  { get; set; }  // 姓

// 姓名の読み取り専用のプロパティ★
public string FullName
{
    // getアクセサーのみ定義
    get { return LastName + FirstName; }
}
```
```cs
使う側：
var person = new Person
    {
        LastName  = "夏目",
        FirstName = "漱石"
    }
var name = person.FllName; //★
```
<br>

#### 10-5-3 その他の読み取り専用のプロパティ
```cs
// 同クラス内のみ代入可
public string Name { get; private set; }
// コンストラクターのみ代入可
public string Name { get; }
```
<br>

#### 10-5-3 その他の読み取り専用のプロパティ
```cs
public string Title     { get; }
public string LastName  { get; set; } = "夏目";
public string FirsrName { get; set; } = "漱石";
public int    Price     { get; set; } = 340;

public Book(string title)
{
    Name = name;
}
```
<br>

## 第11章 値型と参照型
### 11-1 構造体
構造体は機能的にはクラスとほとんど違いがないが、値型である。

#### 11-1-1 構造体の定義方法
構造体を定義するにはclassキーワードの代わりに<mark> structキーワード </mark>をつかう。<br>
また、クラスと同様、名前空間、プロパティ、メソッド、コンストラクター、フィールドを定義できる。

例）Card構造体：
```cs
namespace MyCSharp

// classではなくstructキーワードで構造体を定義
struct Card
{
    // 読み取り専用プロパティ
    public char Suit   { get; private set; }
    public int  Number { get; private set; }

    // コンストラクター
    public Card(char suit, int number)
    {
        Suit = suit;
        Number = number;
    }

    // 構造体にもメソッドを定義できる
    public void Print()
    {
        var s = "";
        switch (Suit)
        {
            case 'H':
                s = "ハート";
                break;
            case 'D':
                s = "ダイヤ";
                break;
            case 'S':
                s = "スペード";
                break;
            case 'C':
                s = "クラブ";
                break;
        }
        Console.WriteLine($"{s} {Number}");
    }
}
```
※上記の通り、構造体では、クラスのclassキーワードがstructに変わっただけで、それ以外はクラスの定義と同じ。
<br><br>


#### 11-1-2 構造体を使ってみる
構造体はクラスと同じように扱える。
<br><br>


#### ＜クラスと構造体の使い分け＞

🧭 結論：この基準で選べばまず間違わない<br>
　✔ struct：“値そのもの”を表す、小さくて不変なデータ<br>
　✔ class ：“振る舞いを持つオブジェクト”や、サイズが大きい・可変<br>
<br>

🧱 class と struct の本質的な違い
| 項目 | class | struct
|--|--|--
| 型分類            | 参照型        | 値型
| メモリ配置        | ヒープ        | スタック（またはインライン）
| 代入時の動作      | 参照コピー    | 値コピー（丸ごと複製）
| デフォルトの可変性 | 可変         | 不変推奨
| 継承              | 可能         | 不可（インターフェイス実装のみ）
| GC の影響         | 受ける       | ほぼ受けない
| サイズ            | 大きくてもOK | 小さいほど良い（16〜32byte目安）
<br>

🎯 struct を使うべきケース<br>
　✔ 1. 小さくて不変な値を表すとき<br>
　　例：`Point`, `DateTime`, `Guid`, `decimal`

```cs
public readonly struct Point(int X, int Y);
```
<br>
　✔ 2. 値のコピーが自然なとき<br>
　　「参照共有」ではなく「値そのもの」を扱う方が直感的なデータ。<br>
　　例：座標、色、範囲、金額、物理量など。<br>
<br>
　✔ 3. パフォーマンスが重要な場面
- 大量のデータを扱うとき
- GC プレッシャーを減らしたいとき
- 配列や Span<T> と組み合わせるとき
<br><br>

🎯 class を使うべきケース<br>
　✔ 1. 状態を持ち、変更されるオブジェクト<br>
　　例：顧客、注文、商品、設定、エンティティ<br>
<br>
　✔ 2. サイズが大きいデータ<br>
　　struct はコピーが重くなるため不向き。<br>
<br>
　✔ 3. 継承やポリモーフィズムが必要<br>
　　struct は継承できないため class 一択。<br>
<br>
　✔ 4. 参照共有が自然なとき<br>
　　複数の場所で同じインスタンスを共有したい場合。<br>
<br>

🧪 具体例で比較<br>
　📌 struct が適切な例<br>
```cs
public readonly struct Money(decimal Amount, string Currency);
```
- 小さい
- 不変
- 値として扱うのが自然
<br><br>

　📌 class が適切な例<br>
```cs
public class Order
{
    public Guid Id { get; }
    public List<OrderItem> Items { get; }
}
```
- 状態を持つ
- 可変
- サイズが大きい
- 参照共有が自然
<br><br>

---

🧭 まとめ（実務での判断基準）
| 判断ポイント | class | struct
|--|--|--
| データの性質 | オブジェクト  | 値そのもの
| 不変性       | 任意         | 必須
| サイズ       | 大きくてもOK | 小さい
| コピーコスト | 高い         | 安い
| GC 負荷     | 高い         | 低い
| 継承        | 可能         | 不可
<br>

### 11-2 列挙型
`...一旦飛ばし...`
<br><br>


### 11-3 値型と参照型
| 型の種類 |  代表的な型
|--|--
| 値型 　  | int、double、decimal、char、bool、構造体、列挙型、レコード型
| 参照型   | string、配列、クラス


<br>

### 11-4 参照先がないことを表すnull
#### 11-4-1 null許容型
型名の末尾に ? を付けると<mark> null許容型 </mark>になる
```cs
int?    number = 123;
double? weight = 87.6;
```
<br>

このnull許容型を、本来の型に変換したい場合、以下のように **キャスト** をするか、

```cs
int    n = (int)number;
double w = (double)weight;
```
<br>

null許容型の特別なプロパティ **Value** を使う必要がある。
```cs
int    n = number.Value;
double w = weight.Value;
```
<br>

ただし、本来の型に変換する前に、nullではないことを確認する必要がある。
```cs
//if(number != null)  // nullチェック
if(number.HasValue)   // Hasvalueプロパティを使いnullチェックをすることもできる
{
    int n = number.Value;
}
```
<br>


## 第12章 リストクラスとLINQ
### 12-1 Listクラス
#### 12-1-1 List<T>のインスタンスを生成する
```cs
using System.Collections.Generic;

var lines   = new List<string>();
var numbers = new List<int>();
```
<br>


#### 12-1-2 リストを初期化する
リストの変数の宣言と同時に初期化
```cs
var lines = new List<string>
    {
        "おはよう",
        "こんにちは",
        "こんばんは",
    };
```
<br>


#### 12-1-3 リストに要素を追加する
```cs
lines.Add("おやすみ");
```
<br>


#### 12-1-4 リストから要素を取り出す
```cs
// リストから要素を取り出す方法は配列と同じ
var str = lines[0];
```

```cs
// リストからすべての要素を取り出す
foreach(var s in lines)
{
    Console.WriteLine(s);
}
```
<br>


#### 12-1-5 リストの要素数を知る
```cs
// リストから要素を取り出す方法は配列と同じ
var count = lines.Count;
```
<br>


#### 12-1-6 リストから要素を削除する
```cs
lines.RemoveAt(2);
```
※要素の削除機能は配列にはない。
<br><br>


#### 12-1-7 リストから全ての要素を削除する
```cs
lines.Clear();
```
<br>


#### [POINT] 配列とリストの使い分け
通常は **「List<T>」** 、要素の追加・削除をしない(させたくない)場合は **「配列」** と使い分ける。

<br>





<br>

### 12-2 LINQを使ってみよう

#### 12-2-1 LINQとは？

**<font color="red">LINQ</font>**（統合言語クエリ）とは、コレクションの操作を統一的に行えるように開発された機能。<br>
これまでよりも短く簡単なコードで、 「List\<T>」 や 「配列」 の操作が可能になる。<br>
LINQでは、どんな場合でもオリジナルのコレクションは変更しないという特徴がある。<br>
<br>

**＜LINQの主なメソッド＞**
| メソッド名 | 説明
|--|--
| Where             | 条件に一致した要素を抜き出す
| Select            | コレクションの各要素を別の値に変換する
| OrderBy           | コレクション内のデータを指定した順番で取り出す（昇順）
| OrderByDescending | 〃　　　　　　　　　　　　　　　　　　（降順）
| Take              | 先頭から指定した個数を取り出す
| Distinct          | コレクションの中から重複した要素を削除する
| Sum               | 合計値
| Max               | 最大値
| Any               | 条件を満たす要素がコレクションに含まれているかを判断（true／false）
| First             | コレクションの最初の要素を返す
| Last              | 〃　　　　 最後の要素を返す
| ToArray           | IEnumerable\<T>を「配列」に変換
| ToList            | IEnumerable\<T>を「List\<T>」に変換
<br>


#### 12-2-2 WHEREメソッドとラムダ式
**<font color="red">WHEREメソッド</font>** は、条件に一致した要素を抜き出す。
```cs
using System.Linq;  // LINQを使うのに必要
...中略...

// ■数値リスト
var nums = new List<int> {12, 56, 75, 8, 12, 95,32 85, 24, 49};

// numsに格納された要素の中から、
// 50以上の数を抜き出す
var query1 = nums.Where(x => x >= 50);
// 30未満の数を抜き出す
var query2 = nums.Where(x => x < 30);
// 偶数だけを抜き出す
var query3 = nums.Where(x => x % 2 == 0);
```
```cs
// ■文字列リスト
var words = new List<string> { "effect", "access", "condition", "sign", "profit", "line", "result" };

// 長さが6の文字列だけ取り出す
var query = words.Where(x => x.Length == 6);
```
```cs
// ■自作クラスリスト
var books = new List<Book>();
...中略...

// 著者が "夏目漱石" の書籍だけ取り出す
var query = books.Where(b => b.Author == "夏目漱石");
```
<br>


#### 12-2-3 Selectメソッド
 **<font color="red">Selectメソッド</font>** は、コレクションの各要素を別の値に変換するメソッド。<br>
（Whereメソッドではラムダ式で与えるのは「条件式」でしたが）、コレクション内の各要素を別のデータに変換するための「式」を書く。
```cs
// ■数値リスト
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// 各要素を2倍する
var query = nums.Select(x => x * 2);
```
```cs
// ■文字列リスト
var words = new List<string> { "effect", "access", "condition", "sign", "profit", "line", "result" };

// 各要素の文字数を求める
var query = words.Select(x => x.Length);
```
```cs
// ■自作クラスリスト
var books = new List<Book>();
...中略...

// 各書籍のタイトルを取り出す
var query = books.Where(b => b.Title);
```
<br>


#### 12-2-4 OrderBy／OrderByDescendingメソッド
* OrderBy　　　　　：コレクション内のデータを指定した順番で取り出す（昇順）
* OrderByDescending：コレクション内のデータを指定した順番で取り出す（降順）
```cs
// ■数値リスト
int[] nums = { 4, 6, 7, 1, 3, 9, 2, 5, 8 };

// 昇順に並べ替える
var query1 = nums.OrderBy(x => x);
// 降順に並べ替える
var query2 = nums.OrderByDescending(x => x);
```
```cs
// ■文字列リスト
var words = new List<string> { "effect", "access", "condition", "sign", "profit", "line", "result" };

// 文字列をアルファベット順に並べ替える
var query = words.OrderBy(x => x);
```
```cs
// ■自作クラスリスト
var books = new List<Book>();
...中略...

// ページ数の多い順に並べ替える
var query = books.OrderByDescending(b => b.Pages);
```
<br>


#### 12-2-5 複数のLINQメソッドを連結させる
```cs
var books = new List<Book>();
...中略...

// 評価が☆5の書籍のタイトルを抜き出す
var query = books
              .Where(b => b.Rating == 5)
              .Select(b => b.Title);
```
```cs
int[] nums = { 4, 6, 7, 1, 3, 9, 2, 5, 8 };

// 大きい順に、先頭の3つを取り出す
var query1 = nums
              .OrderByDescending(x => x);
              .Take(3);
```
```cs
var books = new List<Book>();
...中略...

// 価格が3000円以上の書籍の著者を抜き出し、重複を排除する
var query = books
              .Where(b => b.Price >= 3000)
              .Select(b => b.Author)
              .Distinct();
```
<br>



#### 12-2-6 その他のLINQメソッド
利用頻度が高いと思われるメソッド。<br>
<br>

**■ Sum メソッド**
```cs
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var query = nums.Sum(); // 合計値を求める
```
```cs
var books = new List<Book>();
...中略...
var query = books.Sum(b => b.Pages); // ページ数の合計値を求める
```
<br>

**■ Max メソッド**
```cs
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var query = nums.Max(); // 最大値を求める
```
```cs
var books = new List<Book>();
...中略...
var query = books.Max(b => b.Pages); // ページ数の最大値を求める
```
<br>

**■ Any メソッド**<br>
　条件を満たす要素がコレクションに含まれているかどうかを判断（true／false）
```cs
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var query = nums.Any(x => x < 0); // マイナス値があるか調べる
```
<br>

**■ First／Last メソッド**
```cs
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var query1 = nums.First(); // 最初の要素を取り出す
var query2 = nums.Last();  // 最後の要素を取り出す
```
<br>

**■ ToArray／ToList メソッド**<br>
　LINQの各メソッドが返すデータの型は、配列 や List\<T> ではない。<br>
　戻り値は、IEnumerable\<T> という型になる。<br>
　LINQの各メソッドがは、正確にはこのIEnumerable\<T>に対して利用できるメソッド。<br>
* ToArray：IEnumerable\<T> を **「配列」** に変換する
* ToList　：IEnumerable\<T> を **「List\<T>」** に変換する

```cs
// IEnumerable<T> を「配列」に変換
var array = words.OrderBy(x => x)
                 .ToArray(); //★
```
```cs
// IEnumerable<T> を「List<int>」に変換
var list = words.OrderBy(x => x)
                .ToList(); //★
```
<br><br>



## 第13章 継承

### 13-3 クラスを継承する

#### 13-3-4 メソッドのオーバーライド（上書き）
* 基底クラスのメソッドで <font color="red">virtualキーワード</font> を使い、
* 派生クラスのメソッドで <font color="red">overrideキーワード</font> を使う。
<br><br>
基底クラスでvirtualキーワードを使いメソッドを定義すると、そのメソッドを派生クラスで上書きすることが可能になる。<br>
この virtualキーワード の付いたメソッドを **<font color="red">仮想メソッド</font>** と言う。

<br>




## 第14章 ポリモーフィズム
### 14-3 継承によるポリモーフィズムを導入する
#### 14-3-6 継承を利用しないで複数のクラスを同一視できるか？
* isキーワード：変数に格納されているオブジェクトの実際の型を調べる（true／false）
* asキーワード：変数の型を別の型に変換する演算子
例）
```cs
if(pet is Cat)
{
    var cat = pet as Cat;
}
else if(pet is Dog)
{
    var dog = pet as Dog;
}
```
<br>



### 14-4 継承するための抽象クラスと抽象メソッド
```cs
抽象クラス／抽象メソッドの定義：
abstract class VirtualPet // abstractキーワードで抽象クラスを定義
{
    public string Name { get; private set; }
    public int Mood { get; set; }
    public int Energy { get; set; }

    public VirtualPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }

    // abstractキーワードで抽象メソッドにする。メソッドの本体は書かない
    public abstract void Eat();
    public abstract void Play();
    public abstract void Sleep();
}
```
※メソッドを抽象メソッドとした場合は、派生クラスでは必ず overrideキーワード でメソッドを上書き定義する必要がある。<br>
　（virtualの付いた仮想メソッドはオーバーライドが必須ではないので、オーバーライドし忘れに気が付かないことがある）
<br>



### 14-5 インターフェイスによるポリモーフィズム

```cs
インターフェイスの定義：
interface IVirtualPet  // interfaceキーワードでインターフェイスを定義
{
    string Name { get; }  // getだけを定義
    int Mood { get; set; }
    int Energy { get; set; }
    void Eat();
    void Play();
    void Sleep();
}
```
※インターフェイスの名前は大文字の「I」で始めるのが一般的。<br>
※public や private というキーワードは使わない。<br>
※メソッドの中身は記述しない。<br>
※フィールドは実装の一部であるためインターフェイスでは定義できない。<br>

```cs
インターフェイスの実装側：
class SleepyPet : IVirtualPet    // IVirtualPetインターフェイスを実装したクラスを定義
{
    public string Name { get; private set; }  // setはprivateに
    public int Mood { get; set; }
    public int Energy { get; set; }

    public SleepyPet(string name)
    {
        Name = name;
        Mood = 5;
        Energy = 100;
    }

    public void Eat()  // インターフェイスを実装する場合は、overrideキーワードは不要
    {
        Mood -= 1;
        Energy += 5;
        Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
    }

    public void Play()
    {
        Mood -= 1;
        Energy -= 10;
        Console.WriteLine("SleepyPet.Playメソッドが実行されました");
    }

    public void Sleep()
    {
        Mood += 2;
        Energy += 2;
        Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
    }
}
```
※インターフェイスに定義してあるプロパティとメソッドは必ず実装しなくてはならない。<br>
※インターフェイスで定義したプロパティとメソッドは必ず public にする必要がある。
<br><br><br>


## 第15章 エラーへの対応

### 15-2 例外をキャッチする

#### 15-2-1 例外には種類がある

**＜.NETに定義されている例外の一部＞**
| 例外クラス | 例外の意味
|--|--
| System.DivideByZeroException         | 0で除算した
| System.FormatException               | 引数で渡した文字列の形式がメソッドの要求する形式通りでない
| System.IndexOutOfRageException       | 配列のインデックスが有効範囲外である
| System.IO.FileNotFoundException      | 指定したファイルが存在しない
| System.IO.DirectoryNotFoundException | 指定したディレクトリが存在しない
| System.NullReferenceException        | 
| System.ArgumentsException            | メソッドに渡された引数が無効
| System.Exception                     | すべての例外の基底クラス
<br>

#### 15-2-3 例外オブジェクトにアクセスする
| 使い方 | 意味
|--|--
| ex.GetType()      | 例外の型情報を取得するメソッド
| ex.GetType().Name | 例外の型の名前
| ex.Message        | 例外の内容を示すメッセージ
| ex.TargetSite     | 例外が発生したメソッド名
| ex.StackTrace     | 例外が発生したメソッドの呼び出し階層と、行番号
<br>


#### 15-3 例外を発生させる
**[POINT]**
```cs
if(int.TryParse(line, out var num))
{
    // numには変換された正数が入っている。
    // numを使った処理をここに書く。
}
```
<br>


### 15-4 後始末が必要な場合の「後処理」
#### 15-4-2 IDisposableインターフェイスとDisposeメソッド
IDisposableインターフェイスは後処理が必要なことを示すインターフェイスで、<br>
Disposeという、オブジェクトの後処理をするためのメソッドが定義されている。
```cs
public interface IDisposable
{
    Dispose();
}
```
<br>


#### 15-4-3 using による後処理
IDisposableインターフェイスを実装しているクラスを利用する場合は、using文が使用できる。
```cs
using(var obj = new SampleClass())
{
    // objを利用するコード
}
```
※usingに続く()の中でインスタンスを生成する。<br>
　ここで生成したインスタンスが後処理の対象になる。<br>
　using の { }ブロックから抜けるときに、自動的にDisposeメソッドが呼ばれ、オブジェクトの後処理が行われる。

C#のコンパイラーは、using文に出会うと、try-finally構文を使った以下のコードを自動生成する。
```cs
var obj = new SampleClass();
try
{
    // objを利用するコード
}
finally
{
    obj.Dispose();
}
```

```cs
// ■リスト15-17：using文による後処理
private static void ReadSample()
{
    using (var file = new StreamReader("C:\temp\test.txt"))
    {
        while (file.EndOfStream == false)
        {
            var line = file.ReadLine();
            Console.WriteLine(line);
        }
    }  // Disposeメソッドが書かれていないが、最後にfile.Disposeが呼ばれる
}
```





<br>









<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>

## VisualStudio ショートカットキー

| ショートカット          | 内容 
|------------------------|--
| [F6]                   | ビルド
| [Ctrl] + [Shift] + [B] | 〃
| [Ctrl] + [K] ⇒ [D]    | インデントの自動調整
| [F12]                  | 定義に移動
| [Ctrl] + [-]           | 呼び出し元に戻る
|                        |
| [F5]                   | デバッグの開始
| [Ctrl] + [F5]          | デバッグなしで開始
| [F9]                   | ブレークポイントの設定／解除
| [F10]                  | ステップ オーバー
| [Ctrl] + [F10]         | カーソル行の前まで実行
| [F11]                  | ステップ イン
| [Shift] + [F11]        | ステップ アウト（現在のメソッドから抜け出す）
| [Shift] + [F5]         | デバッグの停止
|  | 
|  | 
|  | 
|  | 
|  | 
|  | 
|  | 

