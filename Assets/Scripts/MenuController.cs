using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuController : MonoBehaviour
{
    public MonoBehaviour defaultMenuState;
    public MonoBehaviour currentMenuState;

    public MonoBehaviour menuOnState;
    public MonoBehaviour menuOffState;

    void Start()
    {
        // Default state is set to off in inspector
        ChangeMenuState(defaultMenuState);
    }
    
    // This works for *any* state
    public void ChangeMenuState(MonoBehaviour newMenuState)
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
        // Currently it's doing both within the frame
        if (Input.GetKeyDown(KeyCode.Escape) && currentMenuState == menuOffState)
        {
            ChangeMenuState(menuOnState);
        }
        else
        {
            ChangeMenuState(menuOffState);
        }
    }
}
