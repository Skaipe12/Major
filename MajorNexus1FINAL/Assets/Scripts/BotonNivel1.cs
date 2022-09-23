using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonNivel1 : MonoBehaviour
{

    private bool isPlayerInRange;
    public GameObject botonNivel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            botonNivel.SetActive(true);
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            botonNivel.SetActive(false);
        }
       
    }

    public void EntrarNivel()
    {
        SceneManager.LoadScene("Prueba");
    }


}
