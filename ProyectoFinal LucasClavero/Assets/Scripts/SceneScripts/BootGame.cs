using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BootGame : MonoBehaviour
{
    void Update()
    {
        StarGame();
    }

    void StarGame() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
