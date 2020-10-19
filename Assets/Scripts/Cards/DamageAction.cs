using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAction : Action
{
    private int damageValue;
    public int DamageValue { get; set; }

    public override bool Do()
    {
        //Target.CharacterController.TakeDamage(damageValue);
        Debug.Log("Deals " + DamageValue + " to " + Target.name);
        return true;
    }

}
