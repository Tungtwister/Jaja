using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            PlayerHealth.totalHealth--;
            Destroy(this.gameObject);
        }
        if (other.name == "ObstacleTile(Clone)" || other.name == "WallTile(Clone)")
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
