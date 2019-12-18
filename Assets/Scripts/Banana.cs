using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject banana;
    public GameObject historiaBanana;
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
                banana.SetActive(true);
                historiaBanana.SetActive(true);
                Time.timeScale = 0;
                personagem.PegaObjeto();
            }
           
        }
    }

    public void ResumeGame()
    {
        historiaBanana.SetActive(false);
        Time.timeScale = 1;
    }
    

    public void Sair()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            historiaBanana.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void DesfazerBanana()
    {
        historiaBanana.SetActive(true);
        Time.timeScale = 0;
    }
}