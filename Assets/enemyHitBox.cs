using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitBox : MonoBehaviour
{
    private int bossHealth;
    private int meleeHealth;
    private int spawnHealth;
    private int projectileHealth;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth = 10;
        meleeHealth = 3;
        spawnHealth = 2;
        projectileHealth = 3;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Attack Trigger L" || other.name == "Attack Trigger R" || other.name == "Attack Trigger D" || other.name == "Attack Trigger U")
        {
            if(this.transform.parent.gameObject.name == "boss(Clone)")
            {
                if (bossHealth <= 0)
                    Destroy(this.transform.parent.gameObject);
                else
                    bossHealth--;
            }
            if(this.transform.parent.gameObject.name == "meleeEnemy(Clone)")
            {
                if (meleeHealth <= 0)
                    Destroy(this.transform.parent.gameObject);
                else
                    meleeHealth--;
            }
            if (this.transform.parent.gameObject.name == "spawnEnemy(Clone)")
            {
                if (spawnHealth <= 0)
                    Destroy(this.transform.parent.gameObject);
                else
                    spawnHealth--;
            }
            if (this.transform.parent.gameObject.name == "projectileEnemy(Clone)")
            {
                if (projectileHealth <= 0)
                    Destroy(this.transform.parent.gameObject);
                else
                    projectileHealth--;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
