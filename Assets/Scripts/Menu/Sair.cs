using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sair : MonoBehaviour
{
    public GameObject saindo;

    

    public void ClicarSair()
    {
        saindo.SetActive(true);
    }

    public void Saindo()
    {
        Application.Quit();
        Debug.Log("Saio");
    }

    public void NaoSair()
    {
        saindo.SetActive(false);
    }

}
