using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JoystickController : MonoBehaviour
{
    public FixedJoystick fixedJoystick;
    public float speed;
    public float TurnSpeed;
    //public Animator animator;

/*
    void Start()
    {
        animator = GetComponent<Animator>();
    }*/

    void FixedUpdate()
    {

        JoystickMovement();
        /*if (Input.GetButton("Fire1"))
        {
            JoystickMovement();
        }*/
    }

    private void JoystickMovement()
    {
        float horizontal = fixedJoystick.Horizontal;
        float vertical = fixedJoystick.Vertical;
        //bool isWalking = animator.GetBool("isWalking");

        
        //if (isWalking)
        //{
            Vector3 addedPos = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
            transform.position += addedPos;

            Vector3 direction = Vector3.forward * vertical + Vector3.right * horizontal;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), TurnSpeed * Time.deltaTime);

        //}

        


    }
}
