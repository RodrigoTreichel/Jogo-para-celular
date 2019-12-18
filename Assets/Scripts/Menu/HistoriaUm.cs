using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoriaUm : MonoBehaviour
{
    public GameObject historiaUmMenu;
    
    void Start()
    {
    
    }

    
    void Update()
    {
        
    }

    public void HistoriaUmAtivo()
    {
        historiaUmMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Fechar()
    {
        historiaUmMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
