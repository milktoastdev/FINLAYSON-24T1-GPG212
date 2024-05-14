using System;
using UnityEngine;
// using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour /* SerializedMonoBehaviour */
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
    
    // TODO: Spawn players from here using a SpawnPoint prefab
    // You can use the InputSystem… system of spawning players, which is its own PlayerManager with the PlayerInput component attached to your players.
    
    // TODO: Create a list of players to keep track of (e.g. List<Player> players)
    
    // TODO: GameWon event
    // Listeners:
    // Game over screen
    // Music manager
    // Player animation
    // Resets
}