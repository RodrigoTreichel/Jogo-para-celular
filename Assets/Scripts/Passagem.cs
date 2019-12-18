using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passagem : MonoBehaviour
{
    Personagem personagem;


    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Personagem>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {



        if (personagem != null)
        {

            if (personagem.objeto == 3)
            {
                Debug.Log("pegou");
            }
            else
            {
                
                Debug.Log("nao pegou");
            }

        }
    }
}
