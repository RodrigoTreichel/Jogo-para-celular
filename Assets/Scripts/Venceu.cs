using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venceu : MonoBehaviour
{

    public GameObject venceu;
    public GameObject quiz;
   
    public void VenceuJogo()
    {
        venceu.SetActive(true);
        quiz.SetActive(false);
    }


   
}
