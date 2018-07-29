using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : LifeController {
    public DeckController deck;
    public HandPlayerBehaviour hand;

	// Use this for initialization
	void Start () {
        base.Start();
        deck.SetUpDeck(this);
        hand.SetPlayer(this);

	}

    // Update is called once per frame
    void Update () {
        base.Update();
	}

    public override void onDamage()
    {
        
    }

    public override void onDie()
    {
        
    }
}
