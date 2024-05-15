using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton that manages higher functionality within the gameplay loop.
/// </summary>
public class GameManager : MonoBehaviour
{
    // Singleton. Simplest version ever.
    // DANGER: Static variables are usually terrible. People accept they get used by managers for ease of use.
    // 'Static' makes the variable belong to the CLASS NAME (so, the whole universe).
    // NOT a particular object in the scene.
    /// <summary>
    /// Singleton for the GameManager for ease of use.
    /// </summary>
    public static GameManager Instance;

    /// <summary>
    /// HACK: Assigns the global game manager to the actual instance in the level.
    /// </summary>
    public void Awake()
    {
        Instance = this;
    }

    // TODO: Implement Functionality
    /// <summary>
    /// List of players to keep track of.
    /// </summary>
    public List<Player> players;

    // TODO: Set up SpawnPoint prefab.
    /// <summary>
    /// Delegate void specifically for spawnables (characters, summons, powerpills).
    /// </summary>
    public delegate void PlayerSpawnDelegateEvent(GameObject prefab, Vector3 spawnPoint);
    
    /// <summary>
    /// Declaring the event for spawning players.
    /// </summary>
    public event PlayerSpawnDelegateEvent SpawnPlayerEvent;
    
    /// <summary>
    /// Invoking the event for spawning players.
    /// </summary>
    public void SpawnPlayerInvoke(GameObject playerToSpawn, Vector3 placeToSpawn)
    {
        // NOTE: You can use the InputSystem… system of spawning players, which is its own PlayerManager with the PlayerInput component attached to your players.
        SpawnPlayerEvent?.Invoke(playerToSpawn, placeToSpawn);
        
        // TODO: Add spawned player to list of players.
    }
    
    /// <summary>
    /// Delegate void for player-related events requiring no other parameters.
    /// </summary>
    public delegate void PlayerDelegateEvent(Player player);
    
    // TODO: Add subscribers --> 'Game Over' screen, music manager, player animation, reset functions.
    /// <summary>
    /// Declaring the event for someone winning the game.
    /// </summary>
    public event PlayerDelegateEvent GameWonEvent;

    /// <summary>
    /// Invoking the event for someone winning the game.
    /// </summary>
    public void GameWonInvoke(Player whoWon)
    {
        GameWonEvent?.Invoke(whoWon);
    }
    
    /// <summary>
    /// Declaring the event for a player changing their preferences.
    /// </summary>
    public event PlayerDelegateEvent PlayerPrefsUpdatedEvent;

    /// <summary>
    /// Invoking the event for a player changing their preferences.
    /// </summary>
    public void PlayerPrefsUpdatedInvoke(Player whoUpdated)
    {
        PlayerPrefsUpdatedEvent?.Invoke(whoUpdated);
    }
}