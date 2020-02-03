using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemy : MonoBehaviour
{
    public float movespeed;
    public float attackCd;
    public float attackTimer;
    public static bool canAttack;
    public bool isAttacking;
    public PlayerController thePlayer;

    // Start is called before the first frame update
    void Start()
    { 
    canAttack = true;
        attackCd = 2f;
        attackTimer = attackCd;

        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (canAttack)
            {
                this.gameObject.transform.LookAt(thePlayer.transform);
                this.transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * 3000);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer -= Time.deltaTime;

        if (attackTimer < 0)
        {
            canAttack = true;
            attackTimer = attackCd;
        }
        else
        {
            canAttack = false;
        }
    }
    
}
