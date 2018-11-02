using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int startingHealth;
    public int currentHealth;
    public int startingAmmo;
    private int currentAmmo;
    public Slider HealthBar;

	// Use this for initialization
	void Start () {

        currentHealth = startingHealth;
        HealthBar.maxValue = startingHealth;

	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth <= 0)
            gameObject.SetActive(false);

	}

    public void HurtPlayer(int damageAmount){

        currentHealth -= damageAmount;
        HealthBar.value = startingHealth;
    }
}
