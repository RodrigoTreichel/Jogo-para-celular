using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinha : MonoBehaviour
{
    public GameObject pinha;
    public GameObject historiaPinha;
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
                pinha.gameObject.SetActive(true);
                historiaPinha.gameObject.SetActive(true);
                Time.timeScale = 0;
                personagem.PegaObjeto();
            }
        }
    }

    public void ResumeGame()
    {
        historiaPinha.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void DesfazerPinha()
    {
        historiaPinha.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}