using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class text : MonoBehaviour
{
    public TMP_Text texta;
    public string currentText;

    public static text instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        texta.text = currentText;
    }

    public void DisableObject()
    {
        this.gameObject.SetActive(false);
    
    }
}
