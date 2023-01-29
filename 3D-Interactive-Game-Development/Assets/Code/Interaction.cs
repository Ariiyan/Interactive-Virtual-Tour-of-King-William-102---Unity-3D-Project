using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{
    public text uiPrompt;


    public bool inFocus;


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            inFocus = true;
            if (SC_FPSController.player.hasCard)
            {
                uiPrompt.currentText = "PRESS F TO INTERACT";
                uiPrompt.gameObject.SetActive(true);
                if (Input.GetKey(KeyCode.F))
                {
                    Debug.Log("Login success");
                    uiPrompt.currentText = "LOGIN SUCCESS";
                    uiPrompt.gameObject.SetActive(true);
                }

            }
            else
            {

                uiPrompt.gameObject.SetActive(true);
                uiPrompt.currentText = "YOU NEED A LOGIN CARD";
                Debug.Log("Authentication failed, you don't have a login card");

            }
        }
     
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            inFocus = false;
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && SC_FPSController.player.hasCard)
        {
            Debug.Log("Login success");
            uiPrompt.currentText = "LOGIN SUCCESS";
            Cursor.lockState = CursorLockMode.None;
            Computer.instance.StartComputer();
            uiPrompt.gameObject.SetActive(true);
        }
    }

}
public enum ObjectType { 

    PersonalComputer,
    GamingConsole
}