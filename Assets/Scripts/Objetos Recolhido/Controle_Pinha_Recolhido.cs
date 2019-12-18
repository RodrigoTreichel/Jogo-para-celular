using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Pinha_Recolhido : MonoBehaviour
{
    public GameObject pinha;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            Destroy(gameObject);

            Personagem personagem = other.GetComponent<Personagem>();

            if (personagem != null)
            {
                pinha.gameObject.SetActive(true);
                personagem.PegaObjeto();
            }
        }
    }
}
