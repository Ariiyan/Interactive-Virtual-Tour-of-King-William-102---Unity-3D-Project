using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{

    public static Computer instance;
    public GameObject startUI;

    private void Awake()
    {
        instance = this;
    }

    public void StartComputer()
    {

        startUI.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Invoke("SwitchScene", 3);

    }

    public void SwitchScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
