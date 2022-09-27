using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonesOhH1 : MonoBehaviour
{

    public GameObject botonReiniciar;
    public GameObject botonRegresar;
    public GameObject botonSolucion;

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void verSolucion()
    {
        SceneManager.LoadScene("OhH1Gana");
    }
}

