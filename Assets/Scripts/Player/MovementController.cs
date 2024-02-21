using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Movement Controls
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    public float moveSpeed;
    
    // Default control inputs, able to be overriden by different players
    // IDK if this is the best way to do this
    public virtual void SetControls()
    {
        // Movement Controls
        moveLeft = KeyCode.A;
        moveRight = KeyCode.S;
        moveJump = KeyCode.W;
        moveSquat = KeyCode.S;
        // P2 : LArrow, RArrow, UArrow, DArrow
    }

    private void Update()
    {
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * moveSpeed);
        }
        
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * moveSpeed);
        }
        
        // Needs && vertical position is not in the air / is not moving up or down?
        // I DONT KNOW
        // at the moment he jus infinite jump
        if (Input.GetKeyDown(moveJump))
        {
            transform.Translate(Vector3.up * moveSpeed);
        }
        
        if (Input.GetKey(moveSquat))
        {
            // Animation of some kind to show squat
            // MMM cube squash
            Debug.Log("I'm squatting :)");
        }
    }
}
