﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    

  

    // Update is called once per frame
    void Update()
    {
        

        
        if ( Input.GetKey("w"))
            {
               rb.AddForce(0, 0, 500 * Time.deltaTime);
            }

        if ( Input.GetKey("s"))
            {
               rb.AddForce(0, 0, -500 * Time.deltaTime);
            }

        if ( Input.GetKey("d"))
            {
               rb.AddForce(500 * Time.deltaTime, 0, 0);
            }

        if ( Input.GetKey("a"))
            {
               rb.AddForce(-500 * Time.deltaTime, 0, 0);
            }
    }
}
