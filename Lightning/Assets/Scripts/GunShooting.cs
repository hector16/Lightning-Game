using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GunShooting : MonoBehaviour {

    public bool isFiring;

    public BulletMovement bullet;
    public float bulletSpeed;

    public Slider AmmoBar;
    public float shotCost;
    public float maxAmmo;
    private float currentAmmo;
    public float reloadRate;
    

    public float timeBetweenShots;
    private float bulletCounter;

    public Transform firePoint;
	// Use this for initialization
	void Start () {
        currentAmmo = maxAmmo;
		AmmoBar.maxValue = maxAmmo;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(isFiring)
        {

            bulletCounter -= Time.deltaTime;
            if(bulletCounter <= 0 && currentAmmo-shotCost > 0)
            {
                currentAmmo -= shotCost;
                bulletCounter = timeBetweenShots;
                BulletMovement newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
                
            }

        }
        else
        {
            bulletCounter = 0;
        }
        currentAmmo += reloadRate;
        if(currentAmmo > maxAmmo){
            currentAmmo = maxAmmo;
        }
        AmmoBar.value = currentAmmo;
	}
}
