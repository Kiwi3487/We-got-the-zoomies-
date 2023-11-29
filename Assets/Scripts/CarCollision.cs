using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    Rigidbody2D rb;
    private CarMovement movement;

    public int currentLap = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = GetComponent <CarMovement>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BoostPad")
        {
            movement.ApplySpeedBoost();
        }
        if (collision.tag == "Start")
        {
            currentLap++;
        }
    }
    public int LapCounter()
    {
        return currentLap;
    }
    
    
}
