using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar2 : MonoBehaviour
{
    [Header("Puzzle")]
    public GameObject text;
    public GameObject caja;
    public GameObject point;
    public bool onTrigger = false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<BoxCollider2D>().CompareTag("CajaAzul"))
        {
  
            StartCoroutine("wait");
            
            onTrigger = true;
        }
    }

    public bool getTriggerState() {
        if (this.onTrigger == true)
        {
            return true;
        }
        else {
            return false;
        }
    }


    IEnumerator wait() { 
        yield return new WaitForSeconds(5);
        text.SetActive(true);
    }

}
