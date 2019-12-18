using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Pause p;
    HistoriaUm h1;
    HistoriaDois h2;
    Historia h;
    Banana b;
    Coco c;
    Pinha pi;
    Portal po;
    Neve n;
    Portugues por;
    Brasil bra;
    
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Pause").GetComponent<Pause>();
        h = GameObject.Find("Historia").GetComponent<Historia>();
        po = GameObject.Find("Portal").GetComponent<Portal>();
        b = GameObject.Find("Banana").GetComponent<Banana>();
        c = GameObject.Find("Coco").GetComponent<Coco>();
        pi = GameObject.Find("Pinha").GetComponent<Pinha>();
        n = GameObject.Find("Neve").GetComponent<Neve>();
        h1 = GameObject.Find("HistoriaUm").GetComponent<HistoriaUm>();
        h2 = GameObject.Find("HistoriaDois").GetComponent<HistoriaDois>();
        //por = GameObject.Find("Portugues").GetComponent<Portugues>();
        bra = GameObject.Find("Brasil").GetComponent<Brasil>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumePlay()
    {
        p.ResumeGame();
        h.ResumeGame();
        b.ResumeGame();
        c.ResumeGame();
        pi.ResumeGame();
        po.ResumeGame();
        n.ResumeGame();
        //por.ResumeGame();
    }

    public void ResumePause()
    {
        p.PauseAtivo();
    }

    public void Brasil()
    {
        bra.BrasilAtivo();
    }

    public void ResumeHistoria()
    {
        h.HistoriaAtivo();
    }

    public void PassarHistoriaH1()
    {
        h1.HistoriaUmAtivo();
    }

    public void PassarHistoriaH2()
    {
        h2.HistoriaDoisAtivo();
    }

    public void VoltarH1()
    {
        h1.Fechar();
    }
    public void VoltarH2()
    {
        h2.Fechar();
    }

    public void Jogar()
    {
        h.Fechar();
        h1.Fechar();
        h2.Fechar();
    }


    public void VoltarLinhaTempo()
    {
        SceneManager.LoadScene("Linha_do_Tempo");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void VoltarLinhaTempoDois()
    {
        SceneManager.LoadScene("Linha_do_Tempo 2");
    }

    public void VoltarLinhaTempoTres()
    {
        SceneManager.LoadScene("Linha_do_Tempo 3");
    }
}
