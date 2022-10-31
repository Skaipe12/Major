 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarEspejo : MonoBehaviour
{
    public KeyCode cuadrado1;
    public GameObject cuadrado;
    bool rotate;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(cuadrado1))
        {
            Rotar();
        }
        
    }

    public void asignarCuadrado(GameObject c) {
        cuadrado = c;
    }

    void Rotar()
    {
        rotate = true;
        cuadrado.transform.Rotate(new Vector3(0f, 0f, 240f) * Time.deltaTime);
        rotate = false;
    }

    

}
