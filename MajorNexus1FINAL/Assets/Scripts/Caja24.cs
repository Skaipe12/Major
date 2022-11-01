using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja24 : MonoBehaviour
{
    int contador = 0;

    void OnMouseDown()
    {
        contador++;

        if (contador % 3 == 2)
        {
            Debug.Log("Has ganado");
        }
    }
}
