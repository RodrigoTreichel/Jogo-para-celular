using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brasil : MonoBehaviour
{

    public GameObject brasil;
   

    public void BrasilAtivo()
    {
        brasil.SetActive(true);
    }

    public void Fechar()
    {
        brasil.SetActive(false);
    }
}
