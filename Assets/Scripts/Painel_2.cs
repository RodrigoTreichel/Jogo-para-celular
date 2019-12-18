using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painel_2 : MonoBehaviour
{
    public GameObject historia;
    public GameObject painelDois;
    

    public void PainelDois()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            painelDois.SetActive(false);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            historia.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
