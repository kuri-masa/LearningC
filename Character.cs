using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

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

    public void printStatsInfo()
    {
        Debug.LogFormat("NAME[{0}] EXP[{1}]",name,exp);
    }

}