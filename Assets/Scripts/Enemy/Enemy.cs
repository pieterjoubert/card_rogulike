using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Unit, IDamageable 
{
    public string Name { get; set; }

    public List<Action> possibleActions { get; set; }

    public string ToString()
    {
        string temp = "";
        temp += Name + "\n";
        temp += HP+ "\n";
        foreach(Action a in possibleActions)
            temp += a.GetType() + "\n";
        return temp;
    }
    public void TakeDamage(int damage)
    {
        HP -= damage;
    }
}
