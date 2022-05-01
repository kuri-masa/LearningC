using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int[] playerScore = { 123, 456, 789 };
    

    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        {"March the tief","Corla the Bounty","Serucia the Brave"};

        Debug.LogFormat("Party Member: {0}", questPartyMembers.Count);

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion",5 },
            {"Antidote",3 },
            {"Aspilin",1 }
        };

        Debug.LogFormat("Item:{0}", itemInventory.Count);

    }

    
    void Update()
    {
        
    }
}
