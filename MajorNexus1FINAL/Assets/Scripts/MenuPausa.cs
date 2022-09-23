using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    public GameObject botonPausa;
    public GameObject menuPausa;
    private bool juegoPausado = false;
    public GameObject menuOpciones;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Configuracion()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
} 