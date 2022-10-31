using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJefe : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D rbd2D;
    public Transform jugador;
    private bool mirandoDerecha = true;

    [Header("Vida")]

    [SerializeField] private float vida;

    //[SerializeField] private BarraDeVida BarraDeVida;

    [Header("Ataque")]

    [SerializeField] private Transform controladorAtaque;
    [SerializeField] private float radioAtaque;
    [SerializeField] private float dañoAtaque;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rbd2D = GetComponent<Rigidbody2D>();
        //BarraDeVida.InicializarBarraDeVida(vida);
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //public void TomarDaño(float daño) 
    //{
    //  vida -= daño;
    //  barraDeVida.CambiarVidaActual(vida);

    //  if (vida <= 0) {
    //      animator.SetTrigger("Muerte");
    //  }

    //}

    private void Muerte() {
        Destroy(gameObject);
    }

    public void MirarJugador() {
        if ((jugador.position.x > transform.position.x && !mirandoDerecha) || (jugador.position.x < transform.position.x && mirandoDerecha)) {
            mirandoDerecha = !mirandoDerecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }

    private void Update() {
        float distanciaJugador = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("distanciaJugador", distanciaJugador);
    }

    public void Ataque() {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorAtaque.position, radioAtaque);

        foreach (Collider2D collision in objetos) {
            if (collision.CompareTag("Player")) {
                //collision.GetComponent<CombateJugador>().TomarDaño(dañoAtaque);
                Debug.Log("DAÑOOOOOO");
            }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorAtaque.position, radioAtaque);
    }

  
}
