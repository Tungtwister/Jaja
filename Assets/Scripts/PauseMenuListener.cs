using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE
// ATTACH THIS TO EventSystem
// PRESSING ESC WILL OPEN A PAUSE MENU

public class PauseMenuListener : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GameObject.Find("PauseMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(!pauseMenu.gameObject.activeSelf);
        }
    }
}
