// ■リスト14-12：ポリモーフィズムを利用する（2）
foreach (var pet in pets)  // petsはList<VirtualPet>型なのでVirtualPet型の変数。foreachについてはp.334参照
{
    pet.Eat();
    pet.Play();
    Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
}
