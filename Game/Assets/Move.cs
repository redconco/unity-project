using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour {

    public int Speed = 1;
    public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	


    private void FixedUpdate()
    {
        float moverHrizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moverHrizontal*Speed,
            0.0f, moverVertical*Speed);

        rigidbody.AddForce(movement);
    }
}
