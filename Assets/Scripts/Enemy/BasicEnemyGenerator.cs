using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyGenerator : EnemyGenerator
{
    public override Enemy Generate(string type)
    {
        if (type == "grunt")
        {
            return new GruntEnemy();
        }
        else if (type == "ranged")
        {
            return new RangedEnemy();
        }
        else return null;
    }
}
