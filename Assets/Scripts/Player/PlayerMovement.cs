using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove;

    public Rigidbody rigidbody;
    
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    
    public float moveSpeed;

    public void Update()
    {
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * moveSpeed);
        }
        
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * moveSpeed);
        }
        
        if (Input.GetKeyDown(moveJump) /* && they aren't already in the air? IDFK */)
        {
            transform.Translate(Vector3.up * moveSpeed);
        }
        
        if (Input.GetKey(moveSquat))
        {
            Debug.Log("I'm squatting :)");
        }
    }

    public void FixedUpdate()
    {
        void MoveLeft()
        {
            rigidbody.AddForce(transform.right * moveSpeed * -1);
        }

        void MoveRight()
        {
            rigidbody.AddForce(transform.right * moveSpeed);
        }

        void MoveJump()
        {
            rigidbody.AddForce(transform.up * moveSpeed);
        }

        void MoveSquat()
        {
            // Squash player to indicate squatting for now
            Debug.Log("I'm squatting :)");
        }
    }
}
