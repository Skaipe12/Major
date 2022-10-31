using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaEnMovimiento : MonoBehaviour
{
    public GameObject objetoAMover;
    public Transform startPoint;
    public Transform endPoint;

    public float velocidad;

    private Vector3 moverHacia;

    // Start is called before the first frame update
    void Start()
    {
        moverHacia = endPoint.position;

    }

    // Update is called once per frame
    void Update()
    {
        objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, moverHacia, velocidad * Time.deltaTime);
    }
}
