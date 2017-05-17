using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

    private Rigidbody box;

	// Use this for initialization
	void Start () {
        box = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontalMovement, 0.0f, verticalMovement);
        box.AddForce(force * 10);
    }
}
