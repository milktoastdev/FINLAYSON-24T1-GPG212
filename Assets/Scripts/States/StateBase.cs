using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    public bool debug = true;

    // Assigned in Inspector
    public StateBase nextState;
    public MonoBehaviour transition;
    
    public delegate void SimpleDelegateStateEvent();

    public event SimpleDelegateStateEvent StateFinished;
    // This cannot go in children of StateBase, hence the invoking is done here
    public void InvokeStateFinished()
    {
        StateFinished?.Invoke();
        if(debug) Debug.Log(GetType().Name + "is done :)");
    }
    
    public virtual void Enter()
    {
        if(debug) Debug.Log(GetType().Name + " : Enter");
    }

    public virtual void Execute()
    {
        if(debug) Debug.Log(GetType().Name + " : Execute");
    }

    public virtual void FixedExecute()
    {
        if(debug) Debug.Log(GetType().Name + " : FixedExecute");
    }

    public virtual void Exit()
    {
        if(debug) Debug.Log(GetType().Name + " : Exit");        
    }
}