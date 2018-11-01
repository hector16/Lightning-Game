using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

    private Vector3 movement;
    private Rigidbody playerRigidbody;

    private Vector3 moveVelocity;

    private Camera mainCamera;

    public GunShooting theGun;

	void Start () {

        playerRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
	}

    private void Update()
    {

        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));

        moveVelocity = movement * speed;

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        float rayLength; 

        if(groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));


        }

        if (Input.GetMouseButtonDown(0))
            theGun.isFiring = true;

        if (Input.GetMouseButtonUp(0))
            theGun.isFiring = false;

    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = moveVelocity;
    }

}
