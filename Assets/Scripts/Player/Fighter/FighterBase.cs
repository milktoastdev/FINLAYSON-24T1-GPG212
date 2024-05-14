using UnityEngine;

/// <summary>
/// Options for players to choose the body colour of their fighter character.
/// Players should not be able to have the same colour.
/// </summary>
public enum FighterColour
{
    Grey,
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Pink,
    Purple
}

/// <summary>
/// Base class for fighter character types.
/// </summary>
public class FighterBase : MonoBehaviour
{
    // Toggles debug logging.
    // Only set in inspector.
    public bool debug;
    
    /// <summary>
    /// Delegates (haha) the required parameters events of this type must use.
    /// All subscribers to this event must also have matching parameters.
    /// In this case, there are no parameters.
    /// </summary>
    public delegate void SimpleFighterDelegateEvent();

    // Movement events for fighter characters.
    public event SimpleFighterDelegateEvent LeftEvent;
    /// <summary>
    /// Invokes the left movement event.
    /// </summary>
    public void OnLeftEvent()
    {
        LeftEvent?.Invoke();
        if(debug) Debug.Log("Left event invoked.");
    }

    public event SimpleFighterDelegateEvent RightEvent;
    /// <summary>
    /// Invokes the right movement event.
    /// </summary>
    public void OnRightEvent()
    {
        RightEvent?.Invoke();
        if(debug) Debug.Log("Right event invoked.");
    }

    public event SimpleFighterDelegateEvent JumpEvent;
    /// <summary>
    /// Invokes the jump event.
    /// </summary>
    public void OnJumpEvent()
    {
        JumpEvent?.Invoke();
        if(debug) Debug.Log("Jump event invoked.");
    }

    public event SimpleFighterDelegateEvent SquatEvent;
    /// <summary>
    /// Invokes the squat event.
    /// </summary>
    public void OnSquatEvent()
    {
        SquatEvent?.Invoke();
        if(debug) Debug.Log("Squat event invoked.");
    }
    
    // Attack events for fighter characters.
    public event SimpleFighterDelegateEvent PunchEvent;
    /// <summary>
    /// Invokes the punch event.
    /// </summary>
    public void OnPunchEvent()
    {
        PunchEvent?.Invoke();
        if(debug) Debug.Log("Punch event invoked.");
    }

    public event SimpleFighterDelegateEvent ComboEvent;
    /// <summary>
    /// Invokes the combo event.
    /// </summary>
    public void OnComboEvent()
    {
        ComboEvent?.Invoke();
        if(debug) Debug.Log("Combo event invoked.");
    }

    public event SimpleFighterDelegateEvent SummonEvent;
    /// <summary>
    /// Invokes the summon event.
    /// </summary>
    public void OnSummonEvent()
    {
        SummonEvent?.Invoke();
        if(debug) Debug.Log("Summon event invoked.");
    }
}