using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    Character hero = new Character();
    

    Weapon huntingBow = new Weapon("Hunting bow", 150);
    

    void Start()
    {
        Character hero2 = hero;
        hero2.name = "sir Krane the Brave";

        hero.printStatsInfo();
        hero2.printStatsInfo();

        Weapon warBow = huntingBow;
        warBow.name = "WarBow";
        warBow.damage = 250;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }


    void Update()
    {
        
    }
}
