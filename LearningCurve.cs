using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    Character heroName = new Character("WLYWNKA");
    Character heroExp = new Character(999);

    Weapon huntingBow = new Weapon("Hunting bow",150);
    Paladin knight = new Paladin("King Areser");

    

    void Start()
    {
        knight.printStatsInfo();

        //heroName.printStatsInfo();
        //heroExp.printStatsInfo();

        //Weapon warBow = huntingBow;
        //warBow.name = "WarBow";
        //warBow.damage = 250;

        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats();
    }


    void Update()
    {
        
    }
}
