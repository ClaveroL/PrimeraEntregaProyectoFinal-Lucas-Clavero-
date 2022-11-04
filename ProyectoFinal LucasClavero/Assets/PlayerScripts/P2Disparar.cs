using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Disparar : MonoBehaviour
{
    public GameObject proyectil;
    public Transform Lanzadera;
    public float fuerza;
    void Update()
    {
        InstaciarBalas();
    }

    void InstaciarBalas()
    {

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            GameObject Bala = Instantiate(proyectil, Lanzadera.position, Lanzadera.rotation);
            Bala.GetComponent<Rigidbody>().AddForce(Lanzadera.forward * fuerza, ForceMode.Impulse);
            Destroy(Bala, 10);
        }

    }

}