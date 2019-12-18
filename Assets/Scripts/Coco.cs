using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coco : MonoBehaviour
{
    public GameObject coco;
    public GameObject historiaCoco;
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
                coco.gameObject.SetActive(true);
                historiaCoco.gameObject.SetActive(true);
                Time.timeScale = 0;
                personagem.PegaObjeto();
            }
        }
    }

    public void ResumeGame()
    {
        historiaCoco.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void DesfazerCoco()
    {
        historiaCoco.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}