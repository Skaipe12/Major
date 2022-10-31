using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mindScript2Azul : MonoBehaviour
{
    public GameObject text;
    activar2 azul;
    activar2Rojo rojo;
    activar2Amarillo amarillo;

    // Update is called once per frame
    void Update()
    {

        if (rojo.onTrigger == true) {
            text.SetActive(true);
            Debug.Log("Holaaa azul x2");
        }

    }
}
