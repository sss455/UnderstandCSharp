// ■リスト14-21：インターフェイスを使ったポリモーフィズム
var pets = new List<IVirtualPet>();  //  petsは、IVirtualPet型のリスト
var pet1 = new FoodiePet("エイミー");
var pet2 = new CheerfulPet("クー");
var pet3 = new SleepyPet("ライアン");
pets.Add(pet1);
pets.Add(pet2);
pets.Add(pet3);

foreach (var pet in pets)  // petsはList<IVirtualPet>型なので、petはIVirtualPet型の変数
{
    pet.Eat();
    pet.Play();
    Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
}
