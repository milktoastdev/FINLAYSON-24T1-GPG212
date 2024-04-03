using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MovementOnState : StateBase
{
    [FormerlySerializedAs("characterMovement")] [FormerlySerializedAs("playerMovement")] public FighterController fighterController;
    
    public void OnEnable()
    {
        Enter();
    }

    public override void Enter()
    {
        fighterController.canMove = true;
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
