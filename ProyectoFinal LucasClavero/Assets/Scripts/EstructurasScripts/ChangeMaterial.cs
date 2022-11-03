using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material roto;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    void Update()
    {
        SeRompio();  
    }
    void SeRompio() 
    {
        int totaldevidas = gameObject.GetComponent<Vidas>().vidas;
        if(totaldevidas <= 0)
        rend.sharedMaterial = roto;
    }
}
