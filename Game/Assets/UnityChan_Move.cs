using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChan_Move : MonoBehaviour {

    public float moveSpeed = 5f;
    public float rotationSpeed = 360f;

    CharacterController characterController;
    Animator animator;

	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if(direction.sqrMagnitude > 0.01f)
        {
            Vector3 forward = Vector3.Slerp(transform.forward, direction, rotationSpeed * Time.deltaTime/Vector3.Angle(transform.forward, direction));

            transform.LookAt(transform.position + forward);
        }
        //충돌을처리
        characterController.Move(direction * moveSpeed * Time.deltaTime);

        //달리는데 애니메이션 추가
        animator.SetFloat("Speed", characterController.velocity.magnitude);
    }
}
