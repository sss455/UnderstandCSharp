// ■リスト14-3：【△】VirtualPetクラスを利用する
var pet = new VirtualPet("ライアン", 3);  // 引数の3は寝坊を表す数字
pet.Play();
pet.Eat();
pet.Sleep();
Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
