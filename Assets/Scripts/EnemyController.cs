using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    public Enemy enemyInfo;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(enemyInfo.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        TextMeshProUGUI outputText =  GameObject.Find("Output").GetComponent<TextMeshProUGUI>();
        outputText.text = enemyInfo.ToString();
    }
}
