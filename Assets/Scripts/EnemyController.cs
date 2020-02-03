using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float movespeed;

    public PlayerController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < 500)
        {
            transform.LookAt(thePlayer.transform.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation
            
            if (Vector3.Distance(transform.position, thePlayer.transform.position) > 1f && Vector3.Distance(transform.position, thePlayer.transform.position) < 150f)
            {//move if distance from target is greater than 1
                transform.Translate(new Vector3(movespeed * Time.deltaTime, 0, 0));
            }
        }
    }

    void FixedUpdate()
    {

    }
}
