using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja44 : MonoBehaviour
{
    int contador = 0;
    bool solucion = false;

    public bool Ganar()
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

        return solucion;
    }
}
