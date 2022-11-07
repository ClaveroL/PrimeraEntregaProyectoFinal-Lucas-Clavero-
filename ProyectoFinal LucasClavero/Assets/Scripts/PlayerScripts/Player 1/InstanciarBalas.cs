using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarBalas : MonoBehaviour
{
    public GameObject proyectil;
    public Transform Lanzadera;
    public float fuerza;
    public Animator Anim;
    void Update()
    {
        InstaciarBalas();
        if (Input.GetKeyDown(KeyCode.L))
        {
            Anim.SetBool("Disparo", true);
        }
        else
        {
            Anim.SetBool("Disparo", false);
        }
    }

    void InstaciarBalas()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject Bala = Instantiate(proyectil, Lanzadera.position, Lanzadera.rotation);
            Bala.GetComponent<Rigidbody>().AddForce(Lanzadera.forward * fuerza, ForceMode.Impulse);
            Destroy(Bala, 10);
        }
        
    }

}
