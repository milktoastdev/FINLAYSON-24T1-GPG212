using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// This only cares about the player's input.
/// Functions that actually force the fighter to move are located in the model.
/// </summary>
public class FighterController : MonoBehaviour
{
    public bool debug;

    public FighterBase fighterBase;

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
    }

    /// <summary>
    /// The inputs here call the functions within FighterBase that invoke their respective events.
    /// </summary>
    public void FixedUpdate()
    {
        if (Input.GetKey(moveLeft) && canMove)
        {
            fighterBase.OnLeftEvent();
        }
        
        if (Input.GetKey(moveRight) && canMove)
        {
            fighterBase.OnRightEvent();
        }
        
        if (Input.GetKeyDown(moveJump) && canMove && canJump)
        {
            fighterBase.OnJumpEvent();
        }
        
        if (Input.GetKey(moveSquat) && canMove)
        {
            fighterBase.OnSquatEvent();
        }
    }

    public void OnDisable()
    {
        canMove = false;
        canJump = false;

        debug = false;
    }
}