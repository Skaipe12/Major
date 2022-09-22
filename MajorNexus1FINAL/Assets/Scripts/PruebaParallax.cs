using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaParallax : MonoBehaviour
{
    public Vector2 velocidad;
    private Vector2 offset;
    private Renderer rnd;
    private Rigidbody2D jugadorRB;

    void Start()
    {
        rnd = GetComponent<Renderer>();
    }

    private void Awake()
    {
        jugadorRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rnd.material.mainTextureOffset = new Vector2(rnd.material.mainTextureOffset.x + velocidad.x * Time.deltaTime, 0);
        offset = (jugadorRB.velocity.x * 0.1f) * velocidad * Time.deltaTime;
        
    }
}
