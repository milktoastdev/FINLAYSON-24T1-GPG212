using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Manages UI events.
/// </summary>
public class UIManager : MonoBehaviour
{
    // TODO: Implement Functionality
    /// <summary>
    /// Refers to the input field where the player adds their name.
    /// </summary>
    public TMP_InputField playerNameInputField;

    // TODO: Implement with File Systems
    // TODO: Add subscribers
    /// <summary>
    /// Delegate void for UI events with no parameters.
    /// Event for the changing of the player name input.
    /// Function to invoke the event above.
    /// </summary>
    public delegate void SimpleDelegateUIEvent();
    public event SimpleDelegateUIEvent playerNameInput;
    public void PlayerNameInput()
    {
        playerNameInput?.Invoke();
    }
}