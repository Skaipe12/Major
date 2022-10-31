using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public CameraController camara;

    void OnMouseDown()
    {
        camara.changePlayer(this.gameObject);
        
    }

}
