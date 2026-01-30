// ■リスト14-2：【△】メソッドの中で処理が分岐するクラス
class VirtualPet
{
    ……

    public void Eat()
    {
        switch (Type)
        {
            case 1:
                // 食いしん坊
                Mood += 4;
                break;
            case 2:
                // 快活
                break;
            case 3:
                // 寝坊
                Mood -= 1;
                break;
        }
        Energy += 5;
    }

    public void Play()
    {
        switch (Type)
        {
            case 1:
                // 食いしん坊
                Mood -= 1;
                break;
            case 2:
                // 快活
                Mood += 5;
                break;
            case 3:
                // 寝坊
                Mood -= 1;
                break;
        }
        Energy -= 10;
    }

    public void Sleep()
    {
        switch (Type)
        {
            case 1:
                // 食いしん坊
                Mood -= 1;
                break;
            case 2:
                // 快活
                Mood -= 2;
                break;
            case 3:
                // 寝坊
                Mood += 3;
                break;
        }
        Energy += 2;
    }
}
