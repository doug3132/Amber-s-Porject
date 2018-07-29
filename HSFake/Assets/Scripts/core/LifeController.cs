using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeController : MonoBehaviour {

    public int totallife;

    protected int currentLife;

	// Use this for initialization
	protected void Start () {
        this.currentLife = this.totallife;
	}
	
	// Update is called once per frame
	protected void Update () {
		
	}

    public void applyDamage(int d)
    {
        this.currentLife -= d;
        onDamage();

        if (currentLife <= 0)
        {
            this.onDie();
        }
    }
    public abstract void onDamage();

    public abstract void onDie();

    public int GetCurrentLife()
    {
        return currentLife;
    }
    public void setCurrentLife(int l)
    {
        currentLife = l;
    }
}
