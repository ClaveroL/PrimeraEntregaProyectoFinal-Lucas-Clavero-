using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarBalas : MonoBehaviour
{
    public GameObject proyectil;
    public Transform Lanzadera;
  
    void Start()
    {
   
    }
    void Update()
    {
        InstaciarBalas();
    }

    void InstaciarBalas()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectil, Lanzadera.position, Lanzadera.rotation);
        }
        
    }
}
