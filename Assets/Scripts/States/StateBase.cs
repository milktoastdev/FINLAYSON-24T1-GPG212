using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class inherited from by all states.
/// </summary>
public class StateBase : MonoBehaviour
{
    /// <summary>
    /// Debug.Logs will print if true.
    /// </summary>
    public bool debug;

    // TODO: Implement Functionality of transition.
    /// <summary>
    /// Assigned in Inspector.
    /// </summary>
    public StateBase nextState;
    public MonoBehaviour transition;
    
    /// <summary>
    /// Delegate void for state events with no parameters.
    /// </summary>
    public delegate void SimpleDelegateStateEvent();

    /// <summary>
    /// Declaring the state finished event.
    /// </summary>
    public event SimpleDelegateStateEvent StateFinished;
    
    /// <summary>
    /// Invoking the state finished event.
    /// </summary>
    public void InvokeStateFinished()
    {
        StateFinished?.Invoke();
        if(debug) Debug.Log(GetType().Name + "is done :)");
    }
    
    /// <summary>
    /// Replaces Unity's OnEnable.
    /// </summary>
    public virtual void Enter()
    {
        if(debug) Debug.Log(GetType().Name + " : Enter");
    }

    /// <summary>
    /// Replaces Unity's Update.
    /// </summary>
    public virtual void Execute()
    {
        if(debug) Debug.Log(GetType().Name + " : Execute");
    }

    /// <summary>
    /// Replaces Unity's FixedUpdate.
    /// </summary>
    public virtual void FixedExecute()
    {
        if(debug) Debug.Log(GetType().Name + " : FixedExecute");
    }

    /// <summary>
    /// Replaces Unity's OnDisable.
    /// </summary>
    public virtual void Exit()
    {
        if(debug) Debug.Log(GetType().Name + " : Exit");        
    }
}