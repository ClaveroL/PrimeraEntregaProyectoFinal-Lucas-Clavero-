using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer1 : MonoBehaviour
{
    public Rigidbody RbPlayer;
    public float Speedmovimiento;
    public float JumpForce;
    bool Floor = false;

  
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        MovimientoPlayer();
    }

    void MovimientoPlayer() 
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        RbPlayer.AddForce(x*Speedmovimiento,0,z*Speedmovimiento);
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
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.5f))
        {
            Floor = true;
        }
        if(Floor == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            RbPlayer.AddForce(Vector3.up*JumpForce);
        }

    }
}
