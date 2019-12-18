using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public float tempoInicio = 60;
    public Text contadoRegressivo;
    public GameObject perdeu;
    // Start is called before the first frame update
    void Start()
    {
        contadoRegressivo.text = tempoInicio.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(tempoInicio >= 0)
        {
            tempoInicio = tempoInicio - Time.deltaTime;
            contadoRegressivo.text = Mathf.Round(tempoInicio).ToString();
        }
        else
        {
            perdeu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
