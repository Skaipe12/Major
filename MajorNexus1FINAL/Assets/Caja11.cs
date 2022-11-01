using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja11 : MonoBehaviour
{
    int contador = 0;
    bool solucion = false;

    void OnMouseDown()
    {
        contador++;

        if (contador % 3 == 1)
        {
            solucion = true;
     
        }
        else
        {
            solucion = false;
        }

    }

    public bool Ganar()
    {
        return solucion;
    }

}
