using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour {

    private Vector3 initialSize;
    private int totalInitialCards;
    private PlayerController player;

    public List<CardBase> listCardDesck;

	// Use this for initialization
	void Start () {
        initialSize = transform.localScale;

        totalInitialCards = listCardDesck.Count;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetCard();
        }
	}

    public void GetCard()
    {
        if (listCardDesck.Count != 0) {
            int randCardIndex = Random.Range(0, listCardDesck.Count - 1);
            CardBase selectCard = listCardDesck[randCardIndex];

            listCardDesck.RemoveAt(randCardIndex);

            Instantiate(selectCard.gameObject, Vector3.zero, selectCard.transform.rotation);
            ReSizeDeck();
        }
    }

    private void ReSizeDeck()
    {
        Vector3 newSize = transform.localScale;

        newSize.x = listCardDesck.Count * initialSize.x / totalInitialCards;
        transform.localScale = newSize;

        if (listCardDesck.Count == 0) {

            GetComponent<Renderer>().enabled = false;
        }
    }

    public void SetUpDeck(PlayerController playerToSet) {
        player = playerToSet;

    }
}
