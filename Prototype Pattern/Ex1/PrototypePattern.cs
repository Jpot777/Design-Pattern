using UnityEngine.Collections;
using UnityEngine.Collections.Generic;
using System;

public interface IUnit
{
    void Clone();
}

public class SCV : IUnit
{
    public int Hp { get; set; }
    public int AttackPower { get; set; }
    public int Armor { get; set; }

    public IUnit Clone()
    {
        return this.MemberwiseClone() as IUnit;
    }
}

public class Probe : IUnit
{
    public int Hp { get; set; }
    public int Shield { get; set; }
    public int AttackPower { get; set; }
    public int Armor { get; set; }

    public IUnit Clone()
    {
        return this.MemberwiseClone() as IUnit;
    }
}