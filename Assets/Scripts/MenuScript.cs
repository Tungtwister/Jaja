using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
  
      public void onClick(string s){
        // Save game data

        // Close game
        switch (s)
        {
            case "New Game":
                print("New Game Clicked");
                SceneManager.LoadScene("jaja");
                break;

            case "Settings":
                print("Clicked Settings");
                break;

            case "Quit":
                print("Application Closing");
                Application.Quit();
                break;

            case "QuitMenu":
                print("Going to Main Menu");
                SceneManager.LoadScene("MainMenu");
                break;
        }


      }
  }