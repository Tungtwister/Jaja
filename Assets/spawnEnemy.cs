using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public float attackCd;
    public float attackTimer;
    public bool isAttacking;
    public PlayerController thePlayer;
    public GameObject Prefab1;
    // Start is called before the first frame update
    void Start()
    {
        attackCd = 7f;
        attackTimer = attackCd;

        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer -= Time.deltaTime;

        if (attackTimer < 0)
        {
            attackTimer = attackCd;
            for (int i = 0; i < 2; i++)
            {
                Vector3 pos = new Vector3(Random.Range(-110, 110), Random.Range(-50, 50), 0);
                var obj = Instantiate(Prefab1, this.transform.parent.position + pos, Quaternion.identity);
                obj.transform.parent = this.transform.parent;
            }
        }

        
    }
}
