using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Historia : MonoBehaviour
{
    public GameObject historiaMenu;
    public GameObject painel;
    public GameObject painelDois;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.M))
        {
            painelDois.SetActive(true);
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            historiaMenu.SetActive(true);
            Time.timeScale = 0;
        }*/
        
    }

    public void HistoriaAtivo()
    {
        historiaMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        painel.SetActive(false);
        painelDois.SetActive(false);
        historiaMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Fechar()
    {
        historiaMenu.SetActive(false);
        Time.timeScale = 1;
    }

}
