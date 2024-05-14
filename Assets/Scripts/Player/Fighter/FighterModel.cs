using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Stores the fighter character's data.
/// </summary>
public class FighterModel : MonoBehaviour
{
    // Toggles debug logging.
    // Only set in inspector.
    public bool debug;
    
    public FighterBase fighter;

    /// <summary>
    /// Determine if the instructions given by the FighterController can be executed here.
    /// </summary>
    // TODO: Link these up to transitions!
    public bool canMove;
    public bool canJump;
    public bool canAttack;
    public bool canSummon;
    
    public void OnEnable()
    {
        // Subscribing to movement events ("setting up")
        fighter.LeftEvent += OnLeftEvent;
        fighter.RightEvent += OnRightEvent;
        // TODO: OnLandEvent? When you collide with the ground, makes canJump true again
        fighter.JumpEvent += OnJumpEvent;
        // TODO: Coroutine? Starts on get key, ends when key is released. Maybe triggers a DIFFERENT event :0
        fighter.SquatEvent += OnSquatEvent;
        
        // Subscribing to attack events ("setting up")
        fighter.PunchEvent += OnPunchEvent;
        fighter.ComboEvent += OnComboEvent;
        fighter.SummonEvent += OnSummonEvent;
    }

    // Movement event functions.
    public void OnLeftEvent()
    {
        if(debug) Debug.Log("MODEL is moving left.");
    }

    public void OnRightEvent()
    {
        if(debug) Debug.Log("MODEL is moving right.");
    }

    public void OnJumpEvent()
    {
        if(debug) Debug.Log("MODEL is jumping.");
    }

    public void OnSquatEvent()
    {
        if(debug) Debug.Log("MODEL is squatting.");
    }
    
    // Attack Event functions.
    public void OnPunchEvent()
    {
        if(debug) Debug.Log("MODEL is punching.");
    }

    public void OnComboEvent()
    {
        if(debug) Debug.Log("MODEL is combo-ing.");
    }

    public void OnSummonEvent()
    {
        if(debug) Debug.Log("MODEL is summoning.");
    }

    public void OnDisable()
    {
        // Unsubscribing from movement events ("cleaning up")
        fighter.LeftEvent -= OnLeftEvent;
        fighter.RightEvent -= OnRightEvent;
        fighter.JumpEvent -= OnJumpEvent;
        fighter.SquatEvent -= OnSquatEvent;
        
        // Unsubscribing from attack events ("cleaning up")
        fighter.PunchEvent -= OnPunchEvent;
        fighter.ComboEvent -= OnComboEvent;
        fighter.SummonEvent -= OnSummonEvent;
    }
}
