using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public GameObject gameMenu;
    public GameObject menuOptions;

	// Use this for initialization
	void Start () {
        this.activeMenu(gameMenu);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hideMenus() {
        gameMenu.SetActive(false);
        menuOptions.SetActive(false);
    }

    public void activeMenu(GameObject menu) {
        this.hideMenus();
        menu.SetActive(true);
    }

    public void exitGame() {
        ApplicationController.exitGame();
    }

    public void playGame()
    {
     SceneManager.LoadScene("GamePlay");
    }
}
