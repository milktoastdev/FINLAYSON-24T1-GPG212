using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleOnState : StateBase
{
    public void OnEnable()
    {
        if(debug) Debug.Log("Title On State : Enabled");
    }

    public override void Enter()
    {
        base.Enter();
        if(debug) Debug.Log("Title On State : Entered");
    }

    public void Update()
    {
        if(debug) Debug.Log("Title On State : Updated");
    }

    public void FixedUpdate()
    {
        if(debug) Debug.Log("Title On State : Fixed Updated");
    }

    public override void Execute()
    {
        base.Execute();
        if(debug) Debug.Log("Title On State : Executed");
    }

    public void OnDisable()
    {
        if(debug) Debug.Log("Title On State : Disabled");
    }

    public override void Exit()
    {
        base.Exit();
        if(debug) Debug.Log("Title On State : Exited");
    }
}
