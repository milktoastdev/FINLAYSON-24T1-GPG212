using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    // Using the 'virtual' keyword allows the function to be overriden in other classes to customise what happens for each state
    
    public virtual void Enter()
    {
        Debug.Log("Default virtual void Enter");
    }

    public virtual void Execute()
    {
        Debug.Log("Default virtual void Execute");
    }

    public virtual void Exit()
    {
        Debug.Log("Default virtual void Exit");        
    }
}