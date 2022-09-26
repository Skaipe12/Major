using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhH1 : MonoBehaviour
{
 
    private int spriteIndex;
    
    public int ColorCuadro()
    {
        spriteIndex++;
        return spriteIndex % 3;
    }
}

