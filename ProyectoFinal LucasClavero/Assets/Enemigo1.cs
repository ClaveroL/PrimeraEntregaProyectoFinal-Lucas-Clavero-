using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    public Transform Playerpos;
    public Rigidbody enemigo;
    void Update()
    {  
     FollowPlayer();
     LookAtPlayer();
    }
    void LookAtPlayer()
    {
        transform.LookAt(Playerpos);
    }
    void FollowPlayer()
    {
        
        float distancia = Vector3.Distance(transform.position, Playerpos.position);
        if (distancia <= 0)
        {
            enemigo.AddForceAtPosition(-transform.forward, transform.position);
        }
        else
        {
            enemigo.AddForceAtPosition(transform.forward*10-new Vector3(0,10,0),transform.position);
        }
    }
    void OnCollisionEnter(Collision Ataque1)
    {
        if (Ataque1.transform.gameObject.tag == "Player1")
        {
            GameObject Playertarget = Ataque1.transform.gameObject;
            Playertarget.GetComponent<Rigidbody>().AddExplosionForce(20000, transform.position, 2);
        }
    }
}


