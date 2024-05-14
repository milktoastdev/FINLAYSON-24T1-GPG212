using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the saving and loading of player preferences set while the game is running (NOT outside of play mode).
/// </summary>
public class SaveManager : MonoBehaviour
{
    /// <summary>
    /// Reference fields chosen by the player.
    /// Player declares their name in an input field.
    /// TODO: Players unable to choose the same name as someone else
    /// Player can rotate through colours in the pause menu.
    /// </summary>
    public string playerName;
    public string playerColour;
    
    // TODO: Input Preferences (Keybinds, etc)
    
    // TODO: Volume Settings
    
    // TODO: Save Score & Highscore
    
    /// <summary>
    /// Saving data using player prefs.
    /// </summary>
    public void SavePlayerPrefs()
    {
        // Editors work outside of play mode. This ensures nothing gets saved while the game isn't running.
        if (Application.isPlaying)
        {
            // Container used by PlayerPrefs is a dictionary.
            // Lists and arrays use an index (number) to look things up, dictionaries use a KEY, then the VALUE.
            PlayerPrefs.SetString("PlayerName",playerName);
            PlayerPrefs.SetString("PlayerColour",playerColour);
        }
    }

    /// <summary>
    /// Loading data using player prefs.
    /// </summary>
    public void LoadPlayerPrefs()
    {
        // Editors work outside of play mode. This ensures nothing gets saved while the game isn't running.
        if (Application.isPlaying)
        {
            playerName = PlayerPrefs.GetString("PlayerName","Player");
            playerColour = PlayerPrefs.GetString("PlayerColour","Grey");
        }
    }
}