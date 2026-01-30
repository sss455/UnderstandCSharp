// ■リスト14-14：【×】継承を使わないFoodiePetクラス等を利用する
foreach (var pet in pets)
{
    if (pet is FoodiePet)  // is演算子を使うことでオブジェクトの型を調べることができる
    {
        var fp = pet as FoodiePet;  // as演算子を使うことで指定した型として扱えるようになる
        fp.Eat();
        fp.Play();
    }
    else if (pet is CheerfulPet)
    {
        var cp = pet as CheerfulPet;
        cp.Eat();
        cp.Play();
    }
    else if (pet is SleepyPet)
    {
        var sp = pet as SleepyPet;
        sp.Eat();
        sp.Play();
    }
}
