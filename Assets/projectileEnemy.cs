using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileEnemy : MonoBehaviour
{
    public float attackCd;
    public float attackTimer;
    public float numShots;
    public PlayerController thePlayer;
    public GameObject projectile;
    public static bool canAttack;

    // Start is called before the first frame update
    void Start()
    {
        numShots = 0;
        canAttack = false;
        attackCd = .5f;
        attackTimer = attackCd;
        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (canAttack)
            {
                numShots++;
                this.gameObject.transform.LookAt(thePlayer.transform);
                var obj = Instantiate(projectile, this.transform.position, Quaternion.identity);
                obj.transform.parent = this.transform.parent;
                obj.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * 3000);
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
            if(numShots == 3)
            {
                numShots = 0;
                attackTimer = 3;
            }
            else
                attackTimer = attackCd;
        }
        else
        {
            canAttack = false;
        }
    }
}
