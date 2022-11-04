using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRespawn : MonoBehaviour
{
    public int RespawnX;
    public int RespawnY;
    public int Team;
    int PuntosTeam1;
    int PuntosTeam2;
    void Update()
    {
        SeMurio();
    }
    void SeMurio() 
    {
        int totalvidas = gameObject.GetComponent<Vidas>().vidas;
        if(totalvidas > 0) 
        {
            transform.position = new Vector3(RespawnX, 0, RespawnY);
            if (Team == 1) 
            {
                PuntosTeam2++;
                Debug.Log(PuntosTeam2);
            }
            if (Team == 2)
            {
                PuntosTeam1++;
                Debug.Log(PuntosTeam1);
            }
        }
    }
}
