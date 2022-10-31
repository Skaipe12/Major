using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar1 : MonoBehaviour {



    [Header("Objeto")]
    public GameObject objeto;
    

    private void OnTriggerStay2D(Collider2D other) {
        if (other.GetComponent<BoxCollider2D>().CompareTag("Player")) {
            objeto.SetActive(true);
        }
    }
}
