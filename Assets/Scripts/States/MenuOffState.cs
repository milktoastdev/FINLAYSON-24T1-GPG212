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

    public override void Enter()
    {
        menuTextMeshProUGUI.enabled = false;
        menuLowPassFilter.enabled = false;
        menuHighPassFilter.enabled = false;
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
        // Play an exit menu sound
    }
}
