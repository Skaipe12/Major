using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarCapsule : MonoBehaviour
{
    [Header("Puzzle")]

    public GameObject caja;
    public GameObject point;
    public bool onTrigger = false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<CapsuleCollider2D>().CompareTag("Capsula"))
        {
            onTrigger = true;
        }
        else {

        }
    }

    public bool getTriggerState()
    {
        if (this.onTrigger == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
