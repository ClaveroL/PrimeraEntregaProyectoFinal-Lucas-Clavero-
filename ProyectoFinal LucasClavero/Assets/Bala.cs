using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody RbBala;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Pesado")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(5000, transform.position, 0.1f);
            Destroy(gameObject);
        }
        if (collision.transform.gameObject.tag == "Mediano")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(15000, transform.position, 0.1f);
            Destroy(gameObject);
        }
        if (collision.transform.gameObject.tag == "Liviano")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(35000, transform.position, 0.1f);
            Destroy(gameObject);
        }
        if (collision.transform.gameObject.tag == "JugadorSano")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(50, transform.position, 0.1f);
            Destroy(gameObject);
        }
        if (collision.transform.gameObject.tag == "JugadorHerido")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(800, transform.position, 0.1f);
            Destroy(gameObject);
        }
        if (collision.transform.gameObject.tag == "JugadorMuyHerido")
        {
            GameObject Blanco = collision.transform.gameObject;
            Blanco.GetComponent<Rigidbody>().AddExplosionForce(5000, transform.position, 0.1f);
            Destroy(gameObject);
        }
    }


}
    