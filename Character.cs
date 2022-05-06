using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    private void Reset()
    {
        this.name = "Not set";
        this.exp = 0;
    }

    //コンストラクト
    public Character()
    {
        name = "no data";
    }
    //カスタムコンストラクト
    public Character(string name)
    {
        this.name = name;
    }
    public Character(int exp)
    {
        this.exp = exp;
    }

    public void printStatsInfo()
    {
        Debug.LogFormat("NAME[{0}] EXP[{1}]",name,exp);
    }

}

//ストラクタ
public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name,int damage)
    {
        this.name = name;
        this.damage = damage;
    
    }

    

    public void PrintWeaponStats()
    {
        Debug.LogFormat("WeaponStats:[{0}] DMG[{1}]", name, damage);
    }

}