// ■リスト14-15：VirtualPetクラス（リスト14-4を再掲）
class VirtualPet
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

    public virtual void Eat()
    {
    }

    public virtual void Play()
    {
    }

    public virtual void Sleep()
    {
    }
}
