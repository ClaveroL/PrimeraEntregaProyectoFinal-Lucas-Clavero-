using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ZonaDeEliminacion : MonoBehaviour
{
    public int Team1Points = 0;
    public int Team2Points = 0;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Zona)
    {
        if (Zona.transform.gameObject.name == "Player1")
        {
            GameObject A1 = Zona.transform.gameObject;
            A1.transform.position = new Vector3(0, 0, 0);
            Team2Points++;
            Debug.Log(Team2Points);
        }

        if (Zona.transform.gameObject.name == "Enemigo1")
        {
            GameObject B1 = Zona.transform.gameObject;
            B1.transform.position = new Vector3(0, 0, 0);
            B1.GetComponent<ImpactosEnemigo1>().vida = 15;
            Team1Points++;
            Debug.Log(Team1Points);
        }
    }
}
