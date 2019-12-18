using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void Start()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LinhaDoTempo()
    {
        SceneManager.LoadScene("Linha_do_Tempo");
    }

    public void Jogo()
    {
        SceneManager.LoadScene("Fase_1");
    }

    public void LinhaDoTempoDois()
    {
        SceneManager.LoadScene("Linha_do_Tempo 2");
    }

    public void JogoDois()
    {
        SceneManager.LoadScene("Fase_2");
    }

    public void LinhaDoTempoTres()
    {
        SceneManager.LoadScene("Linha_do_Tempo 3");
    }

    public void JogoTres()
    {
        SceneManager.LoadScene("Fase_3");
    }

    public void Informacao()
    {
        SceneManager.LoadScene("Informacao");
    }
   
}
