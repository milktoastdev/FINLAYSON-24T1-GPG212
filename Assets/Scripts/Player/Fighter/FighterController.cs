using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class FighterController : MonoBehaviour
{
    public bool debug;

    public FighterBase fighterBase;
    public FighterView fighterView;

    public Rigidbody2D rigidbody2D;
    
    public float moveSpeed;
    
    public bool canMove;
    public bool canJump;
    
    // This will be replaced with action maps
    // Mapped in inspector to arrow keys
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    
    public void OnEnable()
    {
        debug = true;
        
        canMove = true;
        canJump = true;
        
        // Subscribing to movement events ("setting up")
        fighterBase.OnLeft += LeftMove;
        fighterBase.OnRight += RightMove;
        fighterBase.OnJump += JumpMove;
        fighterBase.OnSquat += SquatMove;
    }

    /// <summary>
    /// The inputs here call the function within FighterBase that invokes the respective events
    /// </summary>
    public void FixedUpdate()
    {
        if (Input.GetKey(moveLeft) && canMove)
        {
            fighterBase.OnLeftMove();
        }
        
        if (Input.GetKey(moveRight) && canMove)
        {
            fighterBase.OnRightMove();
        }
        
        if (Input.GetKeyDown(moveJump) && canMove && canJump)
        {
            fighterBase.OnJumpMove();
        }
        
        if (Input.GetKey(moveSquat) && canMove)
        {
            fighterBase.OnSquatMove();
        }
    }
    
    void LeftMove()
    {
        rigidbody2D.AddForce(transform.right * -moveSpeed);
    }

    void RightMove()
    {
        rigidbody2D.AddForce(transform.right * moveSpeed);
    }

    void JumpMove()
    {
        // I will add jump force as it's own variable I'm just being lazy
        rigidbody2D.AddForce(transform.up * (moveSpeed * 100));
    }

    void SquatMove()
    {
        if(debug) Debug.Log("Squatting : " + gameObject);
    }

    public void OnDisable()
    {
        // Unsubscribing from movement events ("cleaning up")
        fighterBase.OnLeft -= LeftMove;
        fighterBase.OnRight -= RightMove;
        fighterBase.OnJump -= JumpMove;
        fighterBase.OnSquat -= SquatMove;

        canMove = false;
        canJump = false;

        debug = false;
    }
}