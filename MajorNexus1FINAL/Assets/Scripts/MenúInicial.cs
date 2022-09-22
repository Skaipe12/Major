using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
    
    
}
