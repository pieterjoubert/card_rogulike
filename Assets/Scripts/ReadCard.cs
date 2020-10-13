using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCard : MonoBehaviour
{
    bool up = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(!up)
        {
            this.transform.position += transform.up * 0.5f;
            up = true;
        }
    }

    void OnMouseExit()
    {
        if(up)
        {
            this.transform.position += transform.up * -0.5f;
            up = false;
        }
    }
}
