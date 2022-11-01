using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFilo : MonoBehaviour
{
    public ScriptJefe jefe;
    public GameObject texto;
    int trampasLayer;


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("NPC"))    
        {
            texto.SetActive(true);
            Muerte();
        }
    }

    private void Muerte()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        trampasLayer = LayerMask.NameToLayer("Trampas");

    }

    
}
