using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {
  
      public void onClick(string s){
        // Save game data

        // Close game
        switch (s)
        {
            case "PAUSED":
                print("PAUSE CLicked");
                break;

            case "Settings":
                print("Clicked Resume");
                break;

            case "QUIT":
                print("Clicked QUIT");
                SceneManager.LoadScene("MainMenu");
                break;
        }


      }
  }