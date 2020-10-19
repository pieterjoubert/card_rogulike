using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonCard : Card
{
    public override bool[] Execute()
    {
        bool[] success = new bool[actions.Count];
        int i = 0;
        foreach (Action a in actions)
        {
            if(a.Do()) { success[i++] = true; }
        }
        return success;
    }
}
