using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    Vector3 moveJump = Vector2.zero;
    float horMove, vertMove;
    GameObject mainCamera, player;
    public static bool isEnabled;

    void Start()
    {
        isEnabled = true;
        mainCamera = GameObject.Find("MainCamera");
        player = GameObject.Find("Player");
        SheetAssigner SA = FindObjectOfType<SheetAssigner>();
        Vector2 tempJump = SA.roomDimensions + SA.gutterSize;
        moveJump = new Vector3(tempJump.x, tempJump.y, 0); //distance b/w rooms: to be used for movement
    }

    public void turnOff()
    {
        this.GetComponent<Collider2D>().isTrigger = false;
    }

    public void turnOn()
    {
        this.GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnabled)
        {
            this.GetComponent<Collider2D>().isTrigger = true;
            Vector3 newCharPos = this.transform.position;

            if (collision.name == "Player")
            {
                // check which door entered to move camera and player
                if (this.name == "DoorTriggerL(Clone)")
                {
                    horMove = -1;
                    vertMove = 0;
                    player.transform.localPosition = new Vector3(106, -23, 20);
                }
                if (this.name == "DoorTriggerR(Clone)")
                {
                    horMove = 1;
                    vertMove = 0;
                    player.transform.localPosition = new Vector3(-106, -23, 20);
                }
                if (this.name == "DoorTriggerU(Clone)")
                {
                    horMove = 0;
                    vertMove = 1;
                    player.transform.localPosition = new Vector3(0, -64, 20);
                }
                if (this.name == "DoorTriggerD(Clone)")
                {
                    horMove = 0;
                    vertMove = -1;
                    player.transform.localPosition = new Vector3(0, 20, 20);
                }

                // Move Camera
                Vector3 tempPos = mainCamera.transform.position;
                tempPos += Vector3.right * horMove * moveJump.x;
                tempPos += Vector3.up * vertMove * moveJump.y;
                mainCamera.transform.position = tempPos;
            }
        }
        else
            this.GetComponent<Collider2D>().isTrigger = false;
    }
}
