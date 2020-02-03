using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public GameObject menu;
    public static bool isEnded;
    // Start is called before the first frame update
    void Start()
    {
        isEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth.totalHealth == 0)
        {
            isEnded = true;
            menu.SetActive(true);
        }
    }
}
