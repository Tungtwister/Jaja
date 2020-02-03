using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Collider2D AttackTriggerU, AttackTriggerD, AttackTriggerL, AttackTriggerR;
    public float speed;             //Floating point variable to store the player's movement speed.
    public Animator hero;
    string m_ClipName;
    AnimatorClipInfo[] m_CurrentClipInfo;
    //public Collider2D attackTrigger;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    //public Animator animator;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        //attackTrigger.enabled = false;
    }

    private void Update()
    {
        hero.SetBool("Up", false);
        hero.SetBool("Down", false);
        hero.SetBool("Left", false);
        hero.SetBool("Right", false);
        m_CurrentClipInfo = hero.GetCurrentAnimatorClipInfo(0);
        m_ClipName = m_CurrentClipInfo[0].clip.name;
        // var firstWord = m_ClipName.Substring(0,m_ClipName.IndexOf(" "));
        if (!GameOverMenu.isEnded)
        {
            switch (m_ClipName)
            {
                case "Attack Left":
                    AttackTriggerL.enabled = true;
                    // print("left is on");
                    break;
                case "Attack Up":
                    AttackTriggerU.enabled = true;
                    // print("up is on");
                    break;
                case "Attack Right":
                    AttackTriggerR.enabled = true;
                    // print("riight is on");
                    break;
                case "Attack Down":
                    AttackTriggerD.enabled = true;
                    // print("down is on");
                    break;
                default:
                    AttackTriggerD.enabled = false;
                    AttackTriggerL.enabled = false;
                    AttackTriggerU.enabled = false;
                    AttackTriggerR.enabled = false;
                    break;
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {

                if (Input.GetKey(KeyCode.W))
                {
                    hero.SetBool("Up", true);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    hero.SetBool("Left", true);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    hero.SetBool("Down", true);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    hero.SetBool("Right", true);
                }
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                Vector3 tempVect = new Vector3(h, v, 0);

                tempVect = tempVect.normalized * speed;
                rb2d.MovePosition(rb2d.transform.position + tempVect);
                speed = 1.5f;

            }
            else
            {
                speed = 0;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                hero.SetTrigger("Attack");
                speed = 0;



            }
        }
    }
}
