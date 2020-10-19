using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public enum TargetType
{
    Self,
    Enemy,
    Hand,
    Deck,
    Map
}
public abstract class Action
{
    private TargetType targetType;
    public TargetType TargetType {get; set;}

    private GameObject target;
    public GameObject Target { get; set; }

    private object param;
    public object Param { get; set; }

    public abstract bool Do();
}
