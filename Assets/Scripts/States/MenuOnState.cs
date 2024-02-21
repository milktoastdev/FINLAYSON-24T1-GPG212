using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOnState : StateBase
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
        menuTextMeshProUGUI.enabled = true;
        menuLowPassFilter.enabled = true;
        menuHighPassFilter.enabled = true;
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
        // Play an enter menu sound
    }
}