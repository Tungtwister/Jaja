using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkIfEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("spawnEnemy(Clone)") == null && GameObject.Find("projectileEnemy(Clone)") == null && GameObject.Find("meleeEnemy(Clone)") == null && GameObject.Find("boss(Clone)")== null)
        {
            DoorTrigger.isEnabled = true;
        }
        else
        {
            DoorTrigger.isEnabled = false;
        }
    }
}
