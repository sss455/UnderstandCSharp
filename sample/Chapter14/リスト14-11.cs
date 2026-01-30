// ■リスト14-11：ポリモーフィズムを利用する（1）
VirtualPet pet1 = new FoodiePet("エイミー");
VirtualPet pet2 = new CheerfulPet("クー");
VirtualPet pet3 = new SleepyPet("ライアン");
var pets = new List<VirtualPet>();
//  3つのオブジェクトをVirtualPet型のリストに格納
pets.Add(pet1);  
pets.Add(pet2);  
pets.Add(pet3); 
