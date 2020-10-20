using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Enemy
{
    public RangedEnemy()
    {
        Name = "Ranged Enemy";
        HP = 10;
        possibleActions = new List<Action>();
        MoveAction m = new MoveAction();
        m.Value = 4;

        possibleActions.Add(m);
    }
}
