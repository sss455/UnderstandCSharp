// ■リスト9-2：名前空間の中にクラスを定義する（2）
namespace MyApp.Drawing
{
    class Location  // Locationクラスは、名前空間MyApp.Drawingに属している
    {
        public int X { get; set; }  // X座標
        public int Y { get; set; }  // Y座標
    }
}
