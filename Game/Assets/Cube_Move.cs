using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Move : MonoBehaviour {

    public float move_sp = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(move_sp *Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-move_sp * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -move_sp * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, move_sp * Time.deltaTime);
        }

    }
}
