using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    public GameObject mapCube;
    public GameObject enemyPrefab;
    public int width;
    public int height;
    // Start is called before the first frame update
    void Start()
    {
       for(int x = 0; x < width;x++)
       {

           for(int z = 0; z < width;z++)
           {
                Instantiate(mapCube, new Vector3(x, 0f, z), Quaternion.identity);
           }
       }

        BasicEnemyGenerator b = new BasicEnemyGenerator();
        Enemy e = b.Spawn("grunt");
        GameObject g = Instantiate(enemyPrefab, new Vector3(2f, 1f, 2f), Quaternion.identity);
        g.GetComponent<EnemyController>().enemyInfo = e;

        Enemy e2 = b.Spawn("ranged");
        GameObject g2 = Instantiate(enemyPrefab, new Vector3(4f, 1f, 8f), Quaternion.identity);
        g2.GetComponent<EnemyController>().enemyInfo = e2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
