using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAction : Action
{
    private int damageValue;
    public int DamageValue { get; set; }

    public override bool Do()
    {
        Enemy e = Target.GetComponent<EnemyController>().enemyInfo;
        e.TakeDamage(DamageValue);

        return true;
    }

}
