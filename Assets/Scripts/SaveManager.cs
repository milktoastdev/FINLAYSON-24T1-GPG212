using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the functions for saving and loading.
/// </summary>
public class SaveManager : MonoBehaviour
{
    // JSON the fuck outta this!
    
    public string playerName;
    public string playerColour;
    // Volume settings
    // Score / Highscore
    // Input settings (keyboard/gamepad)
    
    /// <summary>
    /// Saving data using player prefs
    /// </summary>
    public void SavePlayerPrefs()
    {
        // Editors work outside of play mode. That's scary.
        if (Application.isPlaying)
        {
            // This should be chosen using an input field in a menu
            PlayerPrefs.SetString("PlayerName",playerName);
            PlayerPrefs.SetString("PlayerColour",playerColour);
        }
    }

    /// <summary>
    /// Loading data using player prefs
    /// </summary>
    public void LoadPlayerPrefs()
    {
        // Editors work outside of play mode. That's scary.
        if (Application.isPlaying)
        {
            PlayerPrefs.GetString("PlayerName","PLAYER");
            PlayerPrefs.GetString("PlayerColour","Grey");
        }
    }
}