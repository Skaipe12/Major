using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindScript : MonoBehaviour { 

    public GameObject[] Players;
    [SerializeField]
    GameObject currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Players.Length; i++) {
            
            Players[i].GetComponent<CharacterController1>().enabled = false;
        }

        currentPlayer = Players[0];
    }

    public void changePlayer(GameObject player) {
        
        if (currentPlayer.CompareTag("Player"))
        {
            currentPlayer.GetComponent<PlayerController>().enabled = false;
            currentPlayer = player;
        }
        else {
            currentPlayer.GetComponent<CharacterController1>().enabled = false;
            currentPlayer = player;
        }
    
    }
}
