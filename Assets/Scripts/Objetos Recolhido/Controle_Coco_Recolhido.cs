using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Coco_Recolhido : MonoBehaviour
{
    public GameObject coco;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            Destroy(gameObject);

            Personagem personagem = other.GetComponent<Personagem>();

            if (personagem != null)
            {
                coco.gameObject.SetActive(true);
                personagem.PegaObjeto();
            }
        }
    }
}
