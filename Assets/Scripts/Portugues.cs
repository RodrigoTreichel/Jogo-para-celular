using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portugues : MonoBehaviour
{
    public GameObject historiaPortugueses;
    public GameObject painel_fala_indio;
    public GameObject painel_fala_portugues;
    Personagem personagem;
    
    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Personagem>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            painel_fala_portugues.SetActive(false);
            painel_fala_indio.SetActive(true);
            Time.timeScale = 0;
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            painel_fala_indio.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Personagem")
        {
            HistoriaPortuguesesAtivo();
            painel_fala_portugues.SetActive(true);
            Time.timeScale = 0;

            Update();
        }
    }

    public void HistoriaPortuguesesAtivo()
    {
        historiaPortugueses.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        historiaPortugueses.SetActive(false);
        Time.timeScale = 1;
    }
}
