using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : MonoBehaviour {
    public int manaCard;
    public string nameCard;
    public string descripCard;

    public Texture cardImg;
    public Renderer localCardImg;

   
    public TextMesh txtMana;
    public TextMesh txtNameCard;
    public TextMesh txtDescripCard;

   


    
	// Use this for initialization
	protected void Start () {
       
        txtMana.text = manaCard.ToString();
        txtNameCard.text = nameCard;
        txtDescripCard.text = descripCard;

        localCardImg.material.mainTexture = cardImg;
	}
	
	// Update is called once per frame
	protected void Update () {
       
	}

}
