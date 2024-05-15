using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State for idle, where movement should be locked.
/// </summary>
public class IdleState : StateBase
{
    /// <summary>
    /// References the controller component of the character.
    /// </summary>
    public FighterController fighterController;
    
    /// <summary>
    /// Disables movement in the controller.
    /// </summary>
    public override void Enter()
    {
        fighterController.canMove = false;
        fighterController.canJump = false;
    }

    /// <summary>
    /// Does nothing, required by interface.
    /// </summary>
    public override void Execute()
    {
    }

    /// <summary>
    /// Does nothing, required by interface.
    /// </summary>
    public override void FixedExecute()
    {
    }
    
    /// <summary>
    /// Enables movement in the controller.
    /// </summary>
    public override void Exit()
    {
        fighterController.canMove = true;
        fighterController.canJump = true;
    }
}