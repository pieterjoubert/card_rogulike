using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadCard : MonoBehaviour
{
    bool up = false;
    public int card_id = 0;
    public TMPro.TextMeshProUGUI info;
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
        Debug.Log(card_id);
        info.text = card_id.ToString();
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
