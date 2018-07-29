using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMonster : CardBase {

    public int atk;
    public int life;

    public TextMesh txtAtack;
    public TextMesh txtLife;

    private CardLife cardLife;


    // Use this for initialization
    private void Start () {
        base.Start();
        CardLife cardLife = new CardLife();

        cardLife.setCurrentLife(life);
        txtAtack.text = atk.ToString();
        txtLife.text = cardLife.GetCurrentLife().ToString();

    }
	
	// Update is called once per frame
	private void Update () {
        base.Update();
	}
}
