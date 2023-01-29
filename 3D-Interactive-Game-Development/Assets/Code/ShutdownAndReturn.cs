using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShutdownAndReturn : MonoBehaviour
{

    public GameObject shutdownUI;

    public void Shutdown()
    {
        shutdownUI.SetActive(true);

        Invoke("Return", 3);


    }
    public void Return()
    {
        SceneManager.LoadScene(1);
    }



}
