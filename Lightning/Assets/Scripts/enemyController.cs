using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;

    public Movement thePlayer;


	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<Movement>();

	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(thePlayer.transform.position);
	}

    private void FixedUpdate()
    {

        myRB.velocity = (transform.forward * moveSpeed);

    }
}
