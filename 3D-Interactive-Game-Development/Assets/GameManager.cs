using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //Singletone patttern 

    #region Singleton

    public static GameManager manager;

    private void Awake()
    {
        manager = this;

        if (manager != this)
        {
            Destroy(manager.gameObject);
        }
    }


    #endregion



    [Header("UI REFRENCES")]
    public TMP_Text pickupsText;
    public TMP_Text timeText;


    [Header("GAME REFRENCES")]
    public int totalPickups;
    public int takePickups;

    [Header("GAME SETTINGS")]
    public float maxTime;
    private float timeElapesed;



    public bool gameOver;

    public MonoBehaviour playerScript;
    public GameObject loseUI;
    public GameObject winUI;

    private void Start()
    {
        totalPickups = FindObjectsOfType<Pickup>().Length;
    }


    void Update()
    {
        timeElapesed += Time.deltaTime;
        timeText.text = $"{timeElapesed.ToString("00")} / {maxTime.ToString("00")}";
        pickupsText.text = $"{takePickups} / {totalPickups}";

        
        winUI.SetActive(CheckForWin());
        playerScript.enabled = !CheckGameOver();
        loseUI.SetActive(CheckGameOver());
    }

    bool CheckGameOver(){


        if (timeElapesed >= maxTime && takePickups < totalPickups)
        {
            Cursor.lockState = CursorLockMode.None;
            return true;
        }
        else
            return false;
        
        
        
    }
    bool CheckForWin() {

        if (takePickups == totalPickups)
        {
            Cursor.lockState = CursorLockMode.None;
            return true;
        }
        else {

            return false;
        }
            
    }

    public void ReturnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void ReturnToRetry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
