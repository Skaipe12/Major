using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhH1 : MonoBehaviour
{

    public GameObject pos1;

    private void Awake()
    {
        pos1 = GameObject.Find("1");
    }

    private void MatrizJugada()
    {
        int indice1 = pos1.GetComponent<ScriptTurno>().OnMouseDown();

        if(indice1 == 2)
        {
            Debug.Log("Has ganado!");
        }
    }
    //public int[,] ohH1 = new int[4, 4];

        //ohH1[0, 0] = 1;
        //ohH1[0, 1] = 2;
        //ohH1[0, 2] = 2;
        //ohH1[0, 3] = 1;
        //ohH1[1, 0] = 2;
        //ohH1[1, 1] = 1;
        //ohH1[1, 2] = 1;
        //ohH1[1, 3] = 2;
        //ohH1[2, 0] = 1;
        //ohH1[2, 1] = 2;
        //ohH1[2, 2] = 1;
        //ohH1[2, 3] = 2;
        //ohH1[3, 0] = 2;
        //ohH1[3, 1] = 1;
        //ohH1[3, 2] = 2;
        //ohH1[3, 3] = 1;

}

