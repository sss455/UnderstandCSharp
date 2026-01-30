// ■リスト10-16：引数のあるコンストラクターの呼び出し
Console.Write("名前を入力してください⇒");
var name = Console.ReadLine();
var mypet = new VirtualPet(name);  // 引数を指定したコンストラクターが呼び出される
Console.WriteLine($"Name: {mypet.Name}");
Console.WriteLine($"Mood: {mypet.Mood}");
Console.WriteLine($"Energy: {mypet.Energy}");
