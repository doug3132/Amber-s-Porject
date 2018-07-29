using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPlayerBehaviour : MonoBehaviour {

    private PlayerController player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPlayer(PlayerController playerToSet) {
        player = playerToSet;
    }
}
