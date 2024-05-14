using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Purely player inputs for character movement.
/// </summary>
public class FighterController : MonoBehaviour
{
    /// <summary>
    /// Refers to the model of the character (root GO).
    /// </summary>
    public FighterBase fighterBase;

    // TODO: Move this to the model of the character.
    /// <summary>
    /// Character's rigidbody.
    /// </summary>
    public Rigidbody2D rb2D;
    
    /// <summary>
    /// Force to be applied to the character's rigidbody.
    /// </summary>
    public float moveSpeed;
    
    // TODO: Move these to the model of the character.
    /// <summary>
    /// Make it possible to lock the player's ability to move the character.
    /// </summary>
    public bool canMove;
    public bool canJump;
    
    // TODO: Replace with action map(s)
    /// <summary>
    /// Variables for player movement.
    /// Assigned in inspector to arrow keys.
    /// </summary>
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    
    /// <summary>
    /// Enables players to move the character.
    /// </summary>
    public void OnEnable()
    {
        canMove = true;
        canJump = true;
    }

    /// <summary>
    /// Inputs here call the functions within FighterBase that invoke their respective movement events.
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
            // TODO: Add an OnLandEvent so you can lock and unlock double-jumping or jumping at all.
        }
        
        if (Input.GetKey(moveSquat) && canMove)
        {
            fighterBase.OnSquatEvent();
            // TODO: Lock left, right & jump movement while this is happening.
        }
    }

    /// <summary>
    /// Disables players from moving the character.
    /// </summary>
    public void OnDisable()
    {
        canMove = false;
        canJump = false;
    }
}