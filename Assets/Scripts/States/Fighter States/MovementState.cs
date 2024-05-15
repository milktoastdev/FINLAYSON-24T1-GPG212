using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MovementState : StateBase
{
    /// <summary>
    /// References the controller component of the character.
    /// </summary>
    public FighterController fighterController;

    /// <summary>
    /// Rigidbody of the character.
    /// Speed at which the character should move.
    /// </summary>
    public Rigidbody rb;
    public float speed;

    /// <summary>
    /// HACK: Hardcoded movement inputs.
    /// </summary>
    [Obsolete] // Due to the FighterController.
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    
    /// <summary>
    /// Enables character movement from the controller.
    /// </summary>
    public override void Enter()
    {
        fighterController.canMove = true;
        fighterController.canJump = true;
    }

    public override void Execute()
    {
    }

    /// <summary>
    /// Logic for movement of the player when inputs are made && movement is allowed
    /// </summary>
    public override void FixedExecute()
    {
        if(Input.GetKey(leftKey) && fighterController.canMove)
        {
            rb.AddForce(transform.right * -speed);
        }

        if (Input.GetKey(rightKey) && fighterController.canMove)
        {
            rb.AddForce(transform.right * speed);
        }
    }

    /// <summary>
    /// Disables character movement from the controller.
    /// </summary>
    public override void Exit()
    {
        fighterController.canMove = false;
        fighterController.canJump = false;
    }
}