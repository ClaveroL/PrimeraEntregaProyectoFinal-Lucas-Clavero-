using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Speed;
    public int duracion;

   

    void Start()
    {
        
    }
    void Update()
    {
        ComportamientoBala();
    }
    void ComportamientoBala() 
    {
        transform.Translate(Vector3.forward*Time.deltaTime*Speed);
        Destroy(gameObject,duracion);
        //if (Input.GetKey(KeyCode.Space)) 
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2); 
        } 
        //else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
