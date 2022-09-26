using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTurno : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    GameObject background;
    public Sprite[] imagenes;
    

private void Start()
    {
        spriteRenderer.sprite = imagenes[0];
    }

    private void OnMouseDown()
    {
        int index = background.GetComponent<OhH1>().ColorCuadro();
        spriteRenderer.sprite = imagenes[index]; 
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        background = GameObject.Find("background");
    }
}
