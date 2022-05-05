using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int money = 120;

    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero :name {0} EXP {1}.", hero.name,hero.exp);
    }


    void Update()
    {
        
    }
}
