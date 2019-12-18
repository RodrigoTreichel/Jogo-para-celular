using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoriaDois : MonoBehaviour
{
    public GameObject historiaDoisMenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HistoriaDoisAtivo()
    {
        historiaDoisMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Fechar()
    {
        historiaDoisMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
