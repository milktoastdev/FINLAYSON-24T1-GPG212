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
    /// <summary>
    /// Dictionary to pair key inputs (keys) with their states (value).
    /// </summary>
    public Dictionary<KeyCode, StateBase> transitionDatabase;

    /// <summary>
    /// Refers to the state manager in the scene to call it's functions. The state manager could honestly just be a singleton.
    /// </summary>
    public StateManager stateManager;
    
    /// <summary>
    /// A type of timed-state. Punches & combos would be one such example.
    /// </summary>
    public StateBase timeoutState;

    /// <summary>
    /// Generic containers for a key being pressed or held.
    /// </summary>
    public KeyCode keyPressed;
    public KeyCode keyHeld;
    
    /// <summary>
    /// Generic transition function.
    /// </summary>
    public void Transition(StateBase targetState)
    {
        stateManager.ChangeState(targetState);
    }
    
    /// <summary>
    /// Generic timed transition function.
    /// </summary>
    public void TimedTransition(StateBase targetState, Timer timer, StateBase defaultState)
    {
        // TODO: Set Time.Timescale to a fraction of a second for slowmo effect
    }

    /// <summary>
    /// HACK: Would assign key-state combinations to the dictionary declared above.
    /// </summary>
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
    
    // TODO: States are child GO's of the StateManager GO.
    // TODO: Entire states are toggled on and off this way instead of just their scripts.
}
