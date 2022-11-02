using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeImpactos : MonoBehaviour
{
    private int vida = 50;
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
        if (vida < 20)
        {
            gameObject.tag = "Mediano";
            bien.SetActive(false);
            masomenos.SetActive(true);
            mal.SetActive(false);
        }
        if (vida < 0)
        {
            gameObject.tag = "Liviano";
            bien.SetActive(false);
            masomenos.SetActive(false);
            mal.SetActive(true);
        }
        Debug.Log(vida);
    }
}
