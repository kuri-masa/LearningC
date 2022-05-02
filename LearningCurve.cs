using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    int money = 120;

    void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion" ,5},
            { "MagicDrink",3 },
            { "Arrow",1 }

        };


        foreach (KeyValuePair<string,int> kvp in itemInventory )
        {
            if(kvp.Value <= money)
            Debug.LogFormat("You can buy {0} is {1}　EA",kvp.Key ,money / kvp.Value);
        }

    }

    
    void Update()
    {
        
    }
}
