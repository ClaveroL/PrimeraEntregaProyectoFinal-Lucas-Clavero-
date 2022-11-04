using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ZonaDeEliminacion : MonoBehaviour
{
    public int Team1Points = 0;
    public int Team2Points = 0;
    public GameObject SpawnTeam1;
    public GameObject SpawnTeam2;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Zona)
    {
        if (Zona.transform.gameObject.tag == "Player1")
        {
            GameObject Player1 = Zona.transform.gameObject;
            Player1.transform.position = SpawnTeam1.transform.position;
            Player1.GetComponent<MuerteRespawn>().PuntosTeam2++;
            int a = Player1.GetComponent<MuerteRespawn>().PuntosTeam2++;
            Debug.Log("Puntos TeamAzul = " + a);
        }
        if (Zona.transform.gameObject.tag == "Player2")
        {
            GameObject Player2 = Zona.transform.gameObject;
            Player2.transform.position = SpawnTeam2.transform.position;
            Player2.GetComponent<MuerteRespawn>().PuntosTeam1++;
            int a = Player2.GetComponent<MuerteRespawn>().PuntosTeam1++;
            Debug.Log("Puntos TeamRojo = " + a);
        }


        if (Zona.transform.gameObject.tag == "Enemigo")
        {
            GameObject B1 = Zona.transform.gameObject;
            B1.transform.position = new Vector3(0, 0, 0);
            Team1Points++;
            Debug.Log(Team1Points);
        }

        if (Zona.transform.gameObject.tag == "Estructura") 
        {
            GameObject C1 = Zona.transform.gameObject;
            Destroy(C1);
        }

    }
}
