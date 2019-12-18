using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject quiz;
    public GameObject venceu;
    public GameObject falta;
    Personagem personagem;
    public GameObject passagem;
    public GameObject paineltres;
    public GameObject faltaDois; 
    

    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Personagem>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            paineltres.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            if (personagem != null)
            {
                if (personagem.objeto == 3)
                {
                    quiz.SetActive(true);
                    passagem.SetActive(false);
                    //venceu.SetActive(true);
                    Time.timeScale = 0;
                    Debug.Log("pegou");
                    //paineltres.SetActive(true);
                }
                else if(personagem.objeto > 0 && personagem.objeto < 3)
                {
                    faltaDois.SetActive(true);
                    Time.timeScale = 1;
                    Debug.Log("falta");
                }
                else
                {
                    falta.SetActive(true);
                    Time.timeScale = 1;
                    Debug.Log("nao pegou");
                }
            }
            
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        faltaDois.SetActive(false);

        falta.SetActive(false);

        /*if (personagem != null)
        {
            if (personagem.objeto == 3)
            {
                quiz.SetActive(true);
                passagem.SetActive(false);
                //venceu.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("pegou");
                //paineltres.SetActive(true);
            }
            else if (personagem.objeto > 0 && personagem.objeto < 3)
            {
                faltaDois.SetActive(true);
                Time.timeScale = 1;
                Debug.Log("falta");
            }
            else 
            {
                falta.SetActive(false);
                Time.timeScale = 1;
                Debug.Log("nao pegou");
            }
        }
        */
    }

    public void ResumeGame()
    {
        paineltres.SetActive(false);
        falta.gameObject.SetActive(false);
        faltaDois.SetActive(false);
        Time.timeScale = 1;
    }
}
