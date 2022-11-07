using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteRespawn : MonoBehaviour
{
    public GameObject RespawPoint;
    public int Team;
    public int PuntosTeam1;
    public int PuntosTeam2;
    void Update()
    {
        SeMurio();
        Gano();
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
                Debug.Log("Puntos TeamRojo = " + PuntosTeam1);
                totalvidas = 15;
                gameObject.GetComponent<Vidas>().vidas = totalvidas;
                
            }
            
        }

    }
    void Gano() 
    {
        if (PuntosTeam2 > 7) 
        {
            SceneManager.LoadScene(2);
        }
        if (PuntosTeam1 > 7)
        {
            SceneManager.LoadScene(3);
        }
    }
}
