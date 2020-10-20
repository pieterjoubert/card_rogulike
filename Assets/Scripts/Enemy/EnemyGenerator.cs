using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyGenerator 
{
    public Enemy Spawn(string type)
    {
        Enemy enemy;

        enemy = Generate(type);

        return enemy;
    }

    public abstract Enemy Generate(string type);
}
