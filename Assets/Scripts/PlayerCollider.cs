using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "meleeEnemy(Clone)" || other.name == "projectileEnemy(Clone)" || other.name == "spawnEnemy(Clone)" || other.name == "boss(Clone)")
        {
            PlayerHealth.totalHealth--;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
