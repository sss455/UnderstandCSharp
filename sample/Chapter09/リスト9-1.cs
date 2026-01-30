// ■リスト9-1：名前空間の中にクラスを定義する（1）
namespace MyApp.Map
{
    class Location  // Locationクラスは、名前空間MyApp.Mapに属している
    {
        public double Latitude { get; set; }  // 緯度
        public double Longitude { get; set; } // 経度
    }
}
