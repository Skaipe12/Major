using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTurno : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    GameObject pos1;
    public Sprite[] imagenes;
    int index = 0;



    private void Start()
    {
        spriteRenderer.sprite = imagenes[0];
    }

    public int OnMouseDown()
    { 
        index++;
        index = index % 3;
        spriteRenderer.sprite = imagenes[index];

        return index;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pos1 = GameObject.Find("1");
    }
}