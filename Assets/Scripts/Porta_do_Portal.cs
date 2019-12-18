using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_do_Portal : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        Collider isTrigger;
        Personagem personagem;

        personagem = other.GetComponent<Personagem>();
        isTrigger = GetComponent<Collider>();


        if (other.tag == "Personagem")
        {
            if (personagem != null)
            {
                if (personagem.objeto < 1)
                {
                    isTrigger.isTrigger = true;
                    Destroy(this.gameObject);
                    Debug.Log("pegou");
                }
                else
                {
                    Debug.Log("nao pegou");
                }

            }
        }
    }
}
