using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningEnemy : MonoBehaviour
{
    private Rigidbody myRB;
    public float movespeed;

    public PlayerController thePlayer;

    public GunController theGun1;
    public GunController theGun2;
    public GunController theGun3;
    public GunController theGun4;

    public bool enemyHasGun;
    public bool counterClockwiseRotation;
    private int direction = 1;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        if(counterClockwiseRotation == true)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, direction * 10 * Time.deltaTime, 0);

        if (enemyHasGun == true)
        {
            theGun1.isFiring = true;
            theGun2.isFiring = true;
            theGun3.isFiring = true;
            theGun4.isFiring = true;
        }

    }

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * movespeed);
    }
}