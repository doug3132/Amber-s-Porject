using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public int totalMana;
    public PlayerController player1;
    public int currentTurn = 1;

    public static GameController instance;

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void exitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
