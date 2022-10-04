using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúInicial : MonoBehaviour
{

    GameObject SceneLoadManager;

    public void Jugar()
    {
        //SceneLoadManager.GetComponent<SceneLoadManager>().LoadNextScene();
        SceneManager.LoadScene("Inicio");
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void Awake()
    {
        SceneLoadManager = GameObject.Find("SceneLoadManager");
    }
    
    
}
