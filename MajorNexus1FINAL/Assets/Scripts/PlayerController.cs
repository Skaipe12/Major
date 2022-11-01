using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb2D;

    [Header("Movimiento")]
    private float movimientoHorizontal = 0f;
    public float velocidadDeMovimiento;
    [Range(0, 0.3f)] public float suavizadoDeMovimento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;

    [Header("Salto")]
    public float fuerzaDeSalto;
    public LayerMask queEsSuelo;
    public Transform controladorSuelo;
    public Vector3 dimensionesCaja;
    public bool enSuelo;
    private bool salto = false;
    int trampasLayer;
    int imagenesLayer;

    [Header("Animacion")]
    private Animator animator;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        trampasLayer = LayerMask.NameToLayer("Trampas");
        imagenesLayer = LayerMask.NameToLayer("Imagenes");
    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDeMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));

        if (Input.GetButtonDown("Jump")) 
        {
            salto = true;
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<BoxCollider2D>().CompareTag("Objetos"))
        {
            other.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.layer == trampasLayer)
        {
            Debug.Log("muerto");
        }

      

    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        animator.SetBool("enSuelo", enSuelo);

        //Mover
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);

        salto = false;
    }

    private void Mover(float mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimento);

        if(mover>0 && !mirandoDerecha)
        {
            //Girar
            Girar();
        }
        else if(mover<0 && mirandoDerecha)
        {
            //Girar
            Girar();
        }

        if(enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }


}
