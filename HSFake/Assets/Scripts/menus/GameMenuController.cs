using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuController : MonoBehaviour {

    public GameObject gameMenu;
	// Use this for initialization
	void Start () {
        this.hideMenu();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameMenu.activeSelf)
            {
                this.hideMenu();
            }
            else
            {
                this.showMenu();
            }
        }
	}

    public void showMenu()
    {
        this.gameMenu.SetActive(true);
    }

    public void hideMenu() {
        this.gameMenu.SetActive(false);
    }
}
