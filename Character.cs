using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    LearningCurve system = new LearningCurve();

    public Character()
    {
        name = system.nameC;
    }


}