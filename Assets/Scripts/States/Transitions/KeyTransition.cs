using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// Generic transition script for KEY transitions.
/// </summary>
public class KeyTransition : MonoBehaviour
{
    public Dictionary<KeyCode, StateBase> transitionDatabase = new Dictionary<KeyCode, StateBase>();

    public StateManager stateManager;
    public FighterController fighterController;
    public StateBase timeoutState;

    public KeyCode keyPressed;
    public KeyCode keyHeld;
    
    public void Transition(StateBase targetState)
    {
        stateManager.ChangeState(targetState);
    }
    
    public void TimedTransition(StateBase targetState, Timer timer, StateBase defaultState)
    {
        // TODO: Set Time.Timescale to a fraction of a second for slowmo effect
    }

    private void Awake()
    {
        // TODO: Add states to dictionary.
        // transitionDatabase.Add(fighterController.leftMove,LeftMoveEvent???????);
    }

    /// <summary>
    /// Checks for inputs.
    /// Calls relevant transition function where needed AND possible.
    /// </summary>
    private void FixedUpdate()
    {
        // Pressing a key --> checks if it's in the dictionary first.
        if (Input.GetKeyDown(keyPressed) && transitionDatabase[keyPressed] != null)
        {
            Transition(transitionDatabase[keyPressed]);
        }
        // Holding a key down --> checks if it's in the dictionary first.
        if (Input.GetKey(keyHeld) && transitionDatabase[keyHeld] != null)
        {
            Transition(transitionDatabase[keyHeld]);
        }
    }
    // timeout for combos
    // punches as states become iterations of each other
    // punch
    // punch (1) --> punch again fast enough? whomp whomp back to idle
    // states set a whole game object true or false as opposed to just a component
    // GOs are children of statemanager
    
    // duck
    // punch
    // uppercut
    // do these and show cam WITH transition (if statements & timers!)
    
    // TRANSITIONS!
    // Example: SQUAT can go to left, right and idle depending on the input.
}
