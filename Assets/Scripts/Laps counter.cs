using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Lapscounter : MonoBehaviour
{
    TextMeshProUGUI textField;
    CarCollision collision;


    // Assuming LapCounter() returns an int representing the current lap
    void Start()
    {
        textField = GameObject.Find("Laps").GetComponent<TextMeshProUGUI>();
        collision = FindObjectOfType<CarCollision>();
    
        if (collision == null)
        {
            Debug.LogError("CarCollision script not found");
        }
    }
    // Update is called once per frame
    void Update()
    {
        textField.text = "Lap:  " + collision.LapCounter() + "/3";
    }
}
