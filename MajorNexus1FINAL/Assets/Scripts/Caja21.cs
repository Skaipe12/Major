using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja21 : MonoBehaviour
{
    int contador = 0;
    bool solucion = false;

    public bool Ganar()
    {
        contador++;

        if (contador % 3 == 2)
        {
            solucion = true;
        }
        else
        {
            solucion = false;
        }

        return solucion;
    }
}
