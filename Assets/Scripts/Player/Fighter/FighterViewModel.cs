using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Connects model and view
/// Prepares model data for use by view components
/// </summary>
public class FighterViewModel : MonoBehaviour
{
    public FighterView fighterView;
    public FighterModel fighterModel;
    
    // TODO: Tell the view when the player stops squatting & lands from jumping to reset sprites.
    // This script can be hacked up, it's okay lol.
}