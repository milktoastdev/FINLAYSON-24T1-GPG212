using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOffState : StateBase
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    public AudioLowPassFilter menuLowPassFilter;
    public AudioHighPassFilter menuHighPassFilter;
    
    public void OnEnable()
    {
        Enter();
    }

    public void Update()
    {
    }

    public void FixedUpdate()
    {
    }

    public void OnDisable()
    {
        Exit();
    }
    
    public override void Enter()
    {
        base.Enter();
        
        menuTextMeshProUGUI.enabled = false;
        menuLowPassFilter.enabled = false;
        menuHighPassFilter.enabled = false;
    }
    
    public override void Execute()
    {
        base.Execute();
    }

    public override void Exit()
    {
        base.Exit();
        
        // Play an exit menu sound
    }
}
