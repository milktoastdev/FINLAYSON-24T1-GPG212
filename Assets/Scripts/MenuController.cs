using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuController : MonoBehaviour
{
    public StateBase defaultMenuState;
    public StateBase currentMenuState;

    public StateBase menuOnState;
    public StateBase menuOffState;

    void Start()
    {
        // Default state is set to off in inspector
        ChangeMenuState(defaultMenuState);
    }
    
    // This works for *any* state
    public void ChangeMenuState(StateBase newMenuState)
    {
        if (newMenuState == currentMenuState)
        {
            return;
        }
        
        // Defaults to null
        if (currentMenuState != null)
        {
            currentMenuState.enabled = false;
        }

        newMenuState.enabled = true;

        // New state swap over to incoming state
        currentMenuState = newMenuState;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && currentMenuState != menuOffState)
        {
            ChangeMenuState(menuOffState);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && currentMenuState != menuOnState)
        {
            ChangeMenuState(menuOnState);
        }
    } 
    
    
}
