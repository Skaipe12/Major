using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhH1 : MonoBehaviour
{

    public bool state;

    public GameObject caja11;
    public GameObject caja12;
    public GameObject caja13;
    public GameObject caja14;
    public GameObject caja21;
    public GameObject caja22;
    public GameObject caja23;
    public GameObject caja24;
    public GameObject caja31;
    public GameObject caja32;
    public GameObject caja33;
    public GameObject caja34;
    public GameObject caja41;
    public GameObject caja42;
    public GameObject caja43;
    public GameObject caja44;

    bool C11 = false;
    bool C12 = false;
    bool C13 = false;
    bool C14 = false;
    bool C21 = false;
    bool C22 = false;
    bool C23 = false;
    bool C24 = false;
    bool C31 = false;
    bool C32 = false;
    bool C33 = false;
    bool C34 = false;
    bool C41 = false;
    bool C42 = false;
    bool C43 = false;
    bool C44 = false;



    private void Awake()
    {
        caja11 = GameObject.Find("11");
        caja12 = GameObject.Find("12");
        caja13 = GameObject.Find("13");
        caja14 = GameObject.Find("14");
        caja21 = GameObject.Find("21");
        caja22 = GameObject.Find("22");
        caja23 = GameObject.Find("23");
        caja24 = GameObject.Find("24");
        caja31 = GameObject.Find("31");
        caja32 = GameObject.Find("32");
        caja33 = GameObject.Find("33");
        caja34 = GameObject.Find("34");
        caja41 = GameObject.Find("41");
        caja42 = GameObject.Find("42");
        caja43 = GameObject.Find("43");
        caja44 = GameObject.Find("44");
    }


    public bool OnMouseDown()
    {
         C11 = caja11.GetComponent<Caja11>().Ganar();
         C12 = caja12.GetComponent<Caja12>().Ganar();
         C13 = caja13.GetComponent<Caja13>().Ganar();
         C14 = caja14.GetComponent<Caja14>().Ganar();
         C21 = caja21.GetComponent<Caja21>().Ganar();
         C22 = caja22.GetComponent<Caja22>().Ganar();
         C23 = caja23.GetComponent<Caja23>().Ganar();
         C24 = caja24.GetComponent<Caja24>().Ganar();
         C31 = caja31.GetComponent<Caja31>().Ganar();
         C32 = caja32.GetComponent<Caja32>().Ganar();
         C33 = caja33.GetComponent<Caja33>().Ganar();
         C34 = caja34.GetComponent<Caja34>().Ganar();
         C41 = caja41.GetComponent<Caja41>().Ganar();
         C42 = caja42.GetComponent<Caja42>().Ganar();
         C43 = caja43.GetComponent<Caja43>().Ganar();
         C44 = caja44.GetComponent<Caja44>().Ganar();

        if(C44 == true)
        {
            Debug.Log("Has ganado");
            state = true;
        }
        else
        {
            Debug.Log("Hola");
        }

        return state;

    }


}

