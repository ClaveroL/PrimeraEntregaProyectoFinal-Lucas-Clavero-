using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer1 : MonoBehaviour
{
    public Rigidbody RbPlayer;
    float Speedmovimiento ;
    public float JumpForce;
    bool Floor = false;
    float Cooldown = 0f;

    void FixedUpdate()
    {
        MovimientoPlayer();
    }

    void MovimientoPlayer() 
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        RbPlayer.AddForce(x * Speedmovimiento, 0, z * Speedmovimiento);
        if (x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);           
        }
        if (x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);        
        }
        if (z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);           
        }
        if (z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (x > 0 && z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        if (x < 0 && z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 225, 0);
        }
        if (x < 0 && z > 0)
        {
            transform.rotation = Quaternion.Euler(0, 315, 0);
        }
        if (x > 0 && z < 0)
        {
            transform.rotation = Quaternion.Euler(0, 135, 0);
        }
        if (Physics.Raycast(transform.position,Vector3.down, 1.5f))
        {
            Floor = true;
            Cooldown -= Time.deltaTime;
            Speedmovimiento = 150;

        }
        else 
        {
            Floor = false;
            Speedmovimiento = 80;
        }
        if(Floor == true && Input.GetKey(KeyCode.X) && Cooldown < 0) 
        {
            RbPlayer.AddForceAtPosition(Vector3.up * JumpForce, transform.position, ForceMode.Impulse);
            Cooldown = 0.1f;
        }

        Debug.Log(Speedmovimiento);
    }
}
