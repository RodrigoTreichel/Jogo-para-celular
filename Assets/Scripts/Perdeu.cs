using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdeu : MonoBehaviour
{

    public GameObject perdeu;
    public GameObject quiz;

    public void PerdeuJogo()
    {
        perdeu.SetActive(true);
        quiz.SetActive(false);
    }
}
