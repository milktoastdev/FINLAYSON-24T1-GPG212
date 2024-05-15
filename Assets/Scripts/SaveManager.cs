using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the saving and loading of player preferences set while the game is running (NOT outside of play mode).
/// </summary>
public class SaveManager : MonoBehaviour
{
    // TODO: Editor buttons for testing.
    // TODO: Proper buttons for in-game functionality.
    // TODO: Events for in-game functionality.
    
    // TODO: Implement Functionality
    // TODO: Players unable to choose the same name as someone else
    /// <summary>
    /// Reference fields chosen by the player.
    /// Player declares their name in an input field.
    /// Player can rotate through colours in the pause menu.
    /// </summary>
    public string playerName;
    public string playerColour;
    
    // TODO: Implement Input Preferences (Keybinds, etc) & Functionality
    
    // TODO: Implement Functionality
    /// <summary>
    /// Master volume of the game as a percentage.
    /// </summary>
    public float masterVolume;
    
    // TODO: Implement Functionality
    /// <summary>
    /// Containers for the player's current score this round & their all-time high score.
    /// </summary>
    public int playerScore;
    public int playerHighScore;

    /// <summary>
    /// Subscribes to the player preferences updated event.
    /// </summary>
    public void OnEnable()
    {
        GameManager.Instance.PlayerPrefsUpdatedEvent += OnPlayerPrefsUpdated;
    }

    /// <summary>
    /// Unsubscribes from the player preferences updated event.
    /// </summary>
    public void OnDisable()
    {
        GameManager.Instance.PlayerPrefsUpdatedEvent -= OnPlayerPrefsUpdated;
    }

    /// <summary>
    /// Saves player preferences on the player preferences updated event.
    /// </summary>
    public void OnPlayerPrefsUpdated(Player player)
    {
        // TODO: Make this actually save *individual* player preferences.
        SavePlayerPrefs();
    }

    /// <summary>
    /// Saving data using player prefs.
    /// SETS the player name, colour, score, high score and master volume.
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
            PlayerPrefs.SetInt("PlayerScore",playerScore);
            PlayerPrefs.SetInt("PlayerHighScore",playerHighScore);
            PlayerPrefs.SetFloat("MasterVolume",masterVolume);
        }
    }

    /// <summary>
    /// Loading data using player prefs.
    /// GETS the player name, colour, score, high score and master volume.
    /// </summary>
    public void LoadPlayerPrefs()
    {
        // Editors work outside of play mode. This ensures nothing gets saved while the game isn't running.
        if (Application.isPlaying)
        {
            playerName = PlayerPrefs.GetString("PlayerName","Player");
            playerColour = PlayerPrefs.GetString("PlayerColour","Grey");
            playerScore = PlayerPrefs.GetInt("PlayerScore",0);
            playerHighScore = PlayerPrefs.GetInt("PlayerHighScore",0);
            masterVolume = PlayerPrefs.GetFloat("MasterVolume",1.0f);
        }
    }
}