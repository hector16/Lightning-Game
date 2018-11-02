using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class enemyHealthManager : MonoBehaviour {

    public int health;
    private int currentHealth;
    public int points;
    public Text score;

	// Use this for initialization
	void Start () {

        currentHealth = health;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (currentHealth <= 0)
            Destroy(gameObject);



	}

    public void HurtEnemy(int damage)
    {

        currentHealth -= damage;

    }
}
