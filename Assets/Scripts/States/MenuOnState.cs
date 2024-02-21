using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOnState : StateBase
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    public AudioLowPassFilter menuLowPassFilter;
    void OnEnable()
    {
        Enter();
    }

    public override void Enter()
    {
        menuTextMeshProUGUI.enabled = true;
        menuLowPassFilter.enabled = true;
    }
    
    void Update()
    {
    }

    private void OnDisable()
    {
        // Cut menu music
        
        // Play an exit menu sound
    }

    
}
