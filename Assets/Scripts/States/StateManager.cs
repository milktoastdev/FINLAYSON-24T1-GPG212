using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// Controls the generic transitioning between states
/// </summary>
public class StateManager : MonoBehaviour, IResettable
{
    public StateBase startingState;
    public StateBase currentState;
    public StateBase nextState;
    
    // was gonna put a transition event here

    // Works universally for all states
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

    public void Reset()
    {
        currentState = null;
        
        ChangeState(startingState);
    }

    public void EnterState()
    {
        currentState.Enter();
        // Subscribe to Done event
    }

    public void Update()
    {
        currentState.Execute();
    }

    public void FixedUpdate()
    {
        currentState.FixedExecute();
    }

    public void ExitState()
    {
        currentState.Exit();
        // Unsubscribe from Done event
    }
}