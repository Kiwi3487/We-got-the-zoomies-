using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float accelerationPower;
    [SerializeField] float steeringPower;

    private float steeringInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        steeringInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(accelerationPower * transform.up, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(accelerationPower * -transform.up, ForceMode2D.Force);
        }
        
        rb.MoveRotation(rb.rotation + (-steeringInput * steeringPower));
    }
}
