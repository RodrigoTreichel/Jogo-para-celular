using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int objeto;

    private Animator personagemAnimator;
    private Rigidbody2D personagemRigidbody2D;

    public Transform groundCheck;
    public bool isGround;

    public float velocidade;
    public float touchRun = 0.0f;

    public bool facingRight = true;

    public bool pulo = false;
    public float forcaPulos;

    public int numeroPulo = 0;
    public int maximoPulo = 2;

    private Banana controleBanana;
    private Coco controleCoco;
    private Canvas canvas;

    public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {
        personagemAnimator = GetComponent<Animator>();
        personagemRigidbody2D = GetComponent<Rigidbody2D>();
        controleBanana = GameObject.Find("Canvas").GetComponent<Banana>();
        controleCoco = GameObject.Find("Canvas").GetComponent<Coco>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        this.objeto = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        personagemAnimator.SetBool("isGrounded", isGround);

        /*touchRun = Input.GetAxisRaw("Horizontal");*/
        touchRun = joystick.Horizontal;
        SetaMovimentos();   

        if(Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.UpArrow))
        {
            pulo = true;
        }


    }

    void MoviPerson(float movimentoH)
    {
        personagemRigidbody2D.velocity = new Vector2(movimentoH * velocidade, personagemRigidbody2D.velocity.y);

        if(movimentoH < 0 && facingRight || (movimentoH > 0 && !facingRight))
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        MoviPerson(touchRun);

        if(pulo)
        {
            PuloPerson();
        }
    }

    public void PuloPerson()
    {

        if(isGround)
        {
            numeroPulo = 0;
        }
        if(isGround || numeroPulo < maximoPulo)
        {
            personagemRigidbody2D.AddForce(new Vector2(0f, forcaPulos));
            isGround = false;
            numeroPulo++;
        }
        pulo = false;
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    void SetaMovimentos()
    {
        personagemAnimator.SetBool("Pulo", !isGround);
        personagemAnimator.SetBool("Correndo", personagemRigidbody2D.velocity.x != 0f && isGround);
    }

    public void PegaObjeto()
    {
        objeto++;
    }
}
