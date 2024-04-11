using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleOffState : StateBase
{
    public void OnEnable()
    {
        if(debug) Debug.Log("Title Off State : Enabled");
    }

    public override void Enter()
    {
        base.Enter();
        if(debug) Debug.Log("Title Off State : Entered");
    }

    public void Update()
    {
        if(debug) Debug.Log("Title Off State : Updated");
    }

    public void FixedUpdate()
    {
        if(debug) Debug.Log("Title Off State : Fixed Updated");
    }

    public override void Execute()
    {
        base.Execute();
        if(debug) Debug.Log("Title Off State : Executed");
    }

    public void OnDisable()
    {
        if(debug) Debug.Log("Title Off State : Disabled");
    }

    public override void Exit()
    {
        base.Exit();
        if(debug) Debug.Log("Title Off State : Exited");
    }
}
