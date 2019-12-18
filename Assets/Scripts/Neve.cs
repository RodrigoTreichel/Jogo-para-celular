using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neve : MonoBehaviour
{
    public GameObject neve;
    public GameObject historiaNeve;
    Personagem personagem;

    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Personagem>();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            gameObject.SetActive(false);

            if (personagem != null)
            {
                neve.SetActive(true);
                historiaNeve.SetActive(true);
                Time.timeScale = 0;
                personagem.PegaObjeto();
            }

        }
    }

    public void ResumeGame()
    {
        historiaNeve.SetActive(false);
        Time.timeScale = 1;
    }

    public void DesfazerNeve()
    {
        historiaNeve.SetActive(true);
        Time.timeScale = 0;
        /*gameObject.SetActive(true);
        neve.SetActive(false);
        personagem.LargaObjeto();*/
    }
}
