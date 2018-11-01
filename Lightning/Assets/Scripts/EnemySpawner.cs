﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public PlayerHealthManager playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f; //time between spawns
    public Transform[] spawnPoints; //spawn points


	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn () {

        if (playerHealth.currentHealth <= 0)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}
