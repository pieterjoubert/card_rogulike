using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card 
{
    private string name;
    public string Name { get; set; }
    protected List<Action> actions;
    public abstract bool[] Execute();

    public Card()
    {
        actions = new List<Action>();
    }
    public void AddAction(Action a)
    {
        actions.Add(a);
    }
}
