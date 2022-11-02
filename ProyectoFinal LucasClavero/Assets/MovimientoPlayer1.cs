using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer1 : MonoBehaviour
{
    public Rigidbody RbPlayer;
  
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
        RbPlayer.AddForce(x*15,0,z*15);
     if(x > 0)
      {
         transform.rotation = Quaternion.Euler(0,90,0);
      }
      if(x < 0)
      {
         transform.rotation = Quaternion.Euler(0,270,0);
      }
      if(z > 0)
      {
         transform.rotation = Quaternion.Euler(0,0,0);
      }
      if(z < 0)
      {
         transform.rotation = Quaternion.Euler(0,180,0);
      }
       

    }
}
