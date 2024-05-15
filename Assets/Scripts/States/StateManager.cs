using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// Controls the generic transitioning between states.
/// </summary>
public class StateManager : MonoBehaviour, IResettable
{
    /// <summary>
    /// Containers for the starting (default), current and next state.
    /// </summary>
    public StateBase startingState;
    public StateBase currentState;
    public StateBase nextState;
    
    /// <summary>
    /// Generic function to move between states.
    /// </summary>
    public void ChangeState(StateBase newState)
    {
        if (newState == currentState)
        {
            return;
        }

        // This will be true by default
        if (currentState != null)
        {
            ExitState();
            
            currentState.enabled = false;
        }

        newState.enabled = true;

        currentState = newState;
        
        EnterState();
    }

    /// <summary>
    /// Generic function to reset states to their starting state.
    /// </summary>
    public void Reset()
    {
        currentState = null;
        
        ChangeState(startingState);
    }

    /// <summary>
    /// Runs the 'Enter' function which is inherited by all states.
    /// </summary>
    public void EnterState()
    {
        currentState.Enter();
        // TODO: Subscribe to Done event
    }

    /// <summary>
    /// Runs the 'Execute' function which is inherited by all states.
    /// </summary>
    public void Update()
    {
        currentState.Execute();
    }

    /// <summary>
    /// Runs the 'FixedExecute' function which is inherited by all states.
    /// </summary>
    public void FixedUpdate()
    {
        currentState.FixedExecute();
    }

    /// <summary>
    /// Runs the 'Exit' function which is inherited by all states.
    /// </summary>
    public void ExitState()
    {
        // TODO: Unsubscribe from Done event
        currentState.Exit();
    }
}