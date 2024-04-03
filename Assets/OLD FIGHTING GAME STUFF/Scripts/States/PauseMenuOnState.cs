using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PauseMenuOnState : StateBase
{
    public TextMeshProUGUI pauseMenuTextMeshProUGUI;
    public AudioLowPassFilter pauseMenuLowPassFilter;
    public AudioHighPassFilter pauseMenuHighPassFilter;
    
    public void OnEnable()
    {
        Enter();
    }

    public override void Enter()
    {
        pauseMenuTextMeshProUGUI.enabled = true;
        pauseMenuLowPassFilter.enabled = true;
        pauseMenuHighPassFilter.enabled = true;
    }
    
    public void Update()
    {
        Execute();
    }

    public override void Execute()
    {
        
    }

    public void FixedUpdate()
    {
        FixedExecute();
    }

    public override void FixedExecute()
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
