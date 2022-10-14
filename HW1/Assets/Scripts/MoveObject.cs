using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
 
    private CharacterController controller;
    private float groundDistance;
 
   /* // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController> ();
        groundDistance = player.bounds.extents.y;
    }
 
    // Update is called once per frame
    void Update () {
 
        // get the movement
        float moveFB = Input.GetAxis ("Vertical") * speed;
        float moveLR = Input.GetAxis ("Horizontal") * speed;
 
 
        // handle jumping
        if (isGrounded ()) {
            if (Input.GetButtonDown ("Jump")) {
                gravity += jump;
            }
        }
 
        Vector3 movement = new Vector3 (0, gravity, moveFB);
 
        movement = transform.rotation * movement;
        player.Move (movement * Time.deltaTime);
        transform.Rotate (0, moveLR, 0);
 
    }
 
    void FixedUpdate() {
        if (!isGrounded ()) {
            gravity += (Physics.gravity.y * 2) * Time.deltaTime;
            Debug.Log ("Player is falling");
        } else {
            gravity = 0f;
            Debug.Log ("Player is grounded");
        }
    }
 
    bool isGrounded() {
        return Physics.Raycast (transform.position, -Vector3.up, groundDistance + 0.1f);
    }*/
}
