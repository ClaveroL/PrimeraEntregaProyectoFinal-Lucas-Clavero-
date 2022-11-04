using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRespawn : MonoBehaviour
{
    public GameObject RespawPoint;
    public int Team;
    public int PuntosTeam1;
    public int PuntosTeam2;
    void Update()
    {
        SeMurio();
    }
    void SeMurio() 
    {
        int totalvidas = gameObject.GetComponent<Vidas>().vidas;
        if(totalvidas <= 0) 
        {
            transform.position = RespawPoint.transform.position;
            if (Team == 1) 
            {
                PuntosTeam2++;
                Debug.Log("Puntos TeamAzul = " + PuntosTeam2);
                totalvidas = 15;
                gameObject.GetComponent<Vidas>().vidas = totalvidas;
            }
            if (Team == 2)
            {
                PuntosTeam1++;
                Debug.Log("Puntos TeamRojp = " + PuntosTeam1);
                totalvidas = 15;
                gameObject.GetComponent<Vidas>().vidas = totalvidas;
                
            }
            
        }

    }
}
