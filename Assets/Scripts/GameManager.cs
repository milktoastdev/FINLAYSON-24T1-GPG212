using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton. Simplest version ever.
    // DANGER: Static variables are usually terrible. People accept they get used by managers for ease of use.
    // 'Static' makes the variable belong to the CLASS NAME (so, the whole universe).
    // NOT a particular object in the scene.
    public static GameManager Instance;

    public void Awake()
    {
        // HACK: Assigns the global game manager to the actual instance in the level.
        Instance = this;
    }

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
    }
    
    /// <summary>
    /// Delegate void for player-related events requiring no other parameters.
    /// </summary>
    public delegate void PlayerDelegateEvent(Player player);
    /// <summary>
    /// Declaring the event for someone winning the game.
    /// </summary>
    public event PlayerDelegateEvent GameWonEvent;
    /// <summary>
    /// Declaring the event for a player changing their preferences.
    /// </summary>
    public event PlayerDelegateEvent PlayerPrefsUpdatedEvent;

    // TODO: Create a list of players to keep track of (e.g. List<Player> players)

    // TODO: GameWon event
    // Listeners:
    // Game over screen
    // Music manager
    // Player animation
    // Resets
}