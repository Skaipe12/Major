using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar2Amarillo : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Puzzle")]
    public GameObject caja;
    public GameObject point;
    public bool onTrigger = false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<BoxCollider2D>().CompareTag("CajaAmarilla"))
        {
            onTrigger = true;
        }
    }
}
