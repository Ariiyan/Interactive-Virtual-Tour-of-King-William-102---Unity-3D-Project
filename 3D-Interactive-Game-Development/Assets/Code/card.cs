using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class card : MonoBehaviour
{
    public TMP_Text pickupText;

    public SC_FPSController player;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            pickupText.transform.parent.gameObject.SetActive(true);
            text.instance.currentText = "PICKED UP LOGIN CARD";
            player.hasCard = true;
            Destroy(this.gameObject);
        }
    }
}
