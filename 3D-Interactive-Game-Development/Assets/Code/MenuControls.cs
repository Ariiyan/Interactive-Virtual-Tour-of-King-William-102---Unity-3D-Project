using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MenuControls : MonoBehaviour
{


    // Creating logic for start button


    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }

    // Exit application method
    public void ExitApplication()
    {
        Application.Quit();
    }

  
}
