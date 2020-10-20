using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntEnemy : Enemy
{
    public GruntEnemy()
    {
        Name = "Grunt Enemy";
        HP = 5;
        possibleActions = new List<Action>();
        DamageAction d = new DamageAction();
        d.DamageValue = 10;

        possibleActions.Add(d);
    }
}
