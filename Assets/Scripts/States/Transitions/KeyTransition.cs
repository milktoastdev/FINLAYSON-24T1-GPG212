using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Generic transition script for KEY transitions
/// </summary>
public class KeyTransition : MonoBehaviour
{
    public Dictionary<KeyCode, StateBase> transitionDatabase;

    public StateManager stateManager;
    public StateBase timeoutState;
    
    public KeyCode keyCode;
    
    public void Transition(StateBase targetState)
    {
        stateManager.ChangeState(targetState);
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
