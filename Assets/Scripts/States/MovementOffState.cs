using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOffState : StateBase
{
    public PlayerMovement playerMovement;
    
    public void OnEnable()
    {
        Enter();
    }

    public override void Enter()
    {
        playerMovement.canMove = false;
    }

    public void Update()
    {
        
    }

    public void FixedUpdate()
    {
        
    }

    public override void Execute()
    {
    }

    public void OnDisable()
    {
        Exit();
    }

    public override void Exit()
    {
    }
}
