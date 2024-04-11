using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generic transition script for KEY transitions
/// </summary>
public class KeyTransition : MonoBehaviour
{
    /// <summary>
    /// StateManager script assigned in inspector.
    /// </summary>
    public StateManager stateManager;
    
    /// <summary>
    /// Generic next state.
    /// </summary>
    public StateBase nextState;
    
    /// <summary>
    /// Generic state for timed combos.
    /// </summary>
    public StateBase timeoutState;
    
    /// <summary>
    /// Generic key input for transitions.
    /// </summary>
    public KeyCode keyCode;
    
    // generic transition to next state function
    
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
}
