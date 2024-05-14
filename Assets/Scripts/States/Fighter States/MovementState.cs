using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MovementState : StateBase
{
    public FighterController fighterController;

    public Rigidbody rb;
    public float speed;

    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    
    public override void Enter()
    {
        fighterController.canMove = true;
    }

    public override void Execute()
    {
    }

    public override void FixedExecute()
    {
        if(Input.GetKey(leftKey))
        {
            rb.AddForce(transform.right * -speed);
        }

        if (Input.GetKey(rightKey))
        {
            rb.AddForce(transform.right * speed);
        }
    }

    public override void Exit()
    {
        fighterController.canMove = false;
    }
}