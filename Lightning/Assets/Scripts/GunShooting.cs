using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour {

    public bool isFiring;

    public BulletMovement bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float bulletCounter;

    public Transform firePoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(isFiring)
        {

            bulletCounter -= Time.deltaTime;
            if(bulletCounter <= 0)
            {
                bulletCounter = timeBetweenShots;
                BulletMovement newBullet= Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
            }

        }
        else
        {

            bulletCounter = 0;

        }
	}
}
