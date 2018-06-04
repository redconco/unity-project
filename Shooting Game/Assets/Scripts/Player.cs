using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int hp;
	int speed;
	int moveX;
	int power;
	
	// Use this for initialization
	void Start () {
		hp = 1000;
		speed = 10;
		moveX = 8;
	}
	
	// Update is called once per frame
	void Update () {
		float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

		if(horizontal<0&transform.position.x<-moveX|horizontal>0&transform.position.x>moveX)
			horizontal=0;
		if(vertical>0&transform.position.z>10|vertical<0&transform.position.z<0)
			vertical=0;
		transform.Translate(horizontal,0,vertical);
		Debug.Log(horizontal+","+vertical);
		
	}
}
