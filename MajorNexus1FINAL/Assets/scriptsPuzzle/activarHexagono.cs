using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarHexagono : MonoBehaviour
{
    [Header("Puzzle")]

    public GameObject hex;
    public GameObject point;
    public bool onTrigger = false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PolygonCollider2D>().CompareTag("Hexagono"))
        {
            onTrigger = true;
        }
        else
        {

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
