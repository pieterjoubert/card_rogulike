using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : Action 
{
   private int value;
   public int Value { get; set; }

   public override bool Do()
   {
        Vector3 newPosition = (Vector3)Param;
        if(Vector3.Magnitude(Target.transform.position - newPosition) <= Value)
        {
            Target.transform.position = (Vector3)Param;
            return true;
        }
        else
        {
            return false;
        }
   }
}
