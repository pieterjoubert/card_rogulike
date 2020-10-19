using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public GameObject character;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log(objectHit.position);

                //ALREADY EXISITING CARD
                CommonCard c = new CommonCard();
                MoveAction m = new MoveAction();
                m.TargetType = TargetType.Map;
                m.Value = 5;
                m.Target = character;
                //--------------------
                
                m.Param = new Vector3(objectHit.position.x, character.transform.position.y, objectHit.position.z);
                c.AddAction(m);

                //Damage Action testing
                DamageAction d = new DamageAction();
                d.DamageValue = 10;
                d.TargetType = TargetType.Enemy;
                d.Target = character;

                c.AddAction(d);

                bool[] success = c.Execute();

                Debug.Log("Clicked");
                // Do something with the object that was hit by the raycast.
            }
        }
    }
}
