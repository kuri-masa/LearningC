using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    Character chr = new Character();
    Character chrS = new Character("agasa");

    void Start()
    {
        chr.printStatsInfo();
        chrS.printStatsInfo();

    }


    void Update()
    {
        
    }
}
