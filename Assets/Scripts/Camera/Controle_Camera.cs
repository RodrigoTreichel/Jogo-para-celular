using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_Camera : MonoBehaviour
{
    private Vector2 velocidade;
    private Transform personagem;
    public float smoothTimeX, smoothTimeY;

    // Start is called before the first frame update
    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, personagem.position.x, ref velocidade.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, personagem.position.y, ref velocidade.y, smoothTimeY);
        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
