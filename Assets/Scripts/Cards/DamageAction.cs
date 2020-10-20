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
        //Target.CharacterController.TakeDamage(damageValue);
        Debug.Log("Deals " + DamageValue + " to " + Target.name);
        e.TakeDamage(DamageValue);
        Debug.Log(Target.name + " now has " + e.HP);
        return true;
    }

}
