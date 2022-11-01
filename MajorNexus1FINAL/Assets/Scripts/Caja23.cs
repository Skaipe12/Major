using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja23 : MonoBehaviour
{
    int contador = 0;

    void OnMouseDown()
    {
        contador++;

        if (contador % 3 == 1)
        {
            Debug.Log("Has ganado");
        }
    }
}
