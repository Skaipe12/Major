using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class prueba : MonoBehaviour
{

    public GameObject botonRegresar;

    public void Regresar()
    {
        SceneManager.LoadScene("JuegoOhH1");
    }
}
