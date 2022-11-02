using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactosEnemigo1 : MonoBehaviour
{
    public int vida = 15;
    public GameObject bien;
    public GameObject masomenos;
    public GameObject mal;

    void Start()
    {
        masomenos.SetActive(false);
        mal.SetActive(false);
    }
    void OnCollisionEnter(Collision impacto)
    {
        if (impacto.transform.gameObject.tag == "Bala")
        {
            vida--;
        }
    }

    private void Update()
    {
        if (vida > 10)
        {
            gameObject.tag = "JugadorSano";
            bien.SetActive(true);
            masomenos.SetActive(false);
            mal.SetActive(false);
        }
        if (vida < 10)
        {
            gameObject.tag = "JugadorHerido";
            bien.SetActive(false);
            masomenos.SetActive(true);
            mal.SetActive(false);
        }
        if (vida < 5)
        {
            gameObject.tag = "JugadorMuyHerido";
            bien.SetActive(false);
            masomenos.SetActive(false);
            mal.SetActive(true);
        }
    }
}
