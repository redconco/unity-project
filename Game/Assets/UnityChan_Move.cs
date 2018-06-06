using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class UnityChan_Move : MonoBehaviour {

    public float speedH= 80f;
    public float speedZ =50f;

    public float rotationSpeed = 360f;
    float animSpeed = 1.5f;

    public int hp = 0;

    CharacterController characterController;
    Animator animator;
    Rigidbody rigidbody;
    
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    
    // Update is called once per frame
    void Update()
    {

        moveed();

    }

    private void moveed()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float moveX = h * speedH * Time.deltaTime;
        float moveZ = v * speedZ * Time.deltaTime;

        //if (/*moveZ >= 0 &&*/ !(moveZ == 0 && moveX != 0))
        if (moveZ != 0 || moveX != 0)
        {
            if (hp >= 300)
            {
                animator.Play("REFLESH00", -1, 0);
                hp = 0;
                
            }
            else
            {
                hp++;
                if (moveZ <= 0)
                {
                    moveZ = moveZ * (float)0.5;
                    rigidbody.velocity = new Vector3(0, 0, moveZ);
                }
                else
                {

                    rigidbody.velocity = new Vector3(moveX, 0, moveZ);
                    animator.SetFloat("h", h);
                }
                animator.SetFloat("v", v);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("JUMP", -1, 0);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        animator.Play("DAMAGED00", -1, 0);
        this.transform.Translate(Vector3.back * 100 * Time.deltaTime);

        if(collision.collider.tag == "장판")
        {
            animator.Play("DAMAGED01", -1, 0);
        }
    }

}

