using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPersona : MonoBehaviour
{
    public MindScript mind;



    void OnMouseDown() {
        mind.changePlayer(this.gameObject);
        if (this.gameObject.CompareTag("Player"))
        {
            GetComponent<PlayerController>().enabled = true;
        }
        else {
            GetComponent<CharacterController1>().enabled = true;
        }
       
    }
}
