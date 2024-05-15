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
    /// <summary>
    /// Debug.Logs are written when this is true.
    /// </summary>
    public bool debug;
    
    /// <summary>
    /// Delegates (haha) the required parameters events of this type must use.
    /// All subscribers to this event must also have matching parameters.
    /// In this case, there are no parameters.
    /// </summary>
    public delegate void SimpleFighterDelegateEvent();

    /// <summary>
    ///  Declares the left movement event.
    /// </summary>
    public event SimpleFighterDelegateEvent LeftEvent;
    
    /// <summary>
    /// Invokes the left movement event.
    /// </summary>
    public void OnLeftEvent()
    {
        LeftEvent?.Invoke();
        if(debug) Debug.Log("Left event invoked.");
    }

    /// <summary>
    /// Declares the right movement event.
    /// </summary>
    public event SimpleFighterDelegateEvent RightEvent;
    
    /// <summary>
    /// Invokes the right movement event.
    /// </summary>
    public void OnRightEvent()
    {
        RightEvent?.Invoke();
        if(debug) Debug.Log("Right event invoked.");
    }

    /// <summary>
    /// Declares the jump event.
    /// </summary>
    public event SimpleFighterDelegateEvent JumpEvent;
    
    /// <summary>
    /// Invokes the jump event.
    /// </summary>
    public void OnJumpEvent()
    {
        JumpEvent?.Invoke();
        if(debug) Debug.Log("Jump event invoked.");
    }

    /// <summary>
    /// Declares the squat event.
    /// </summary>
    public event SimpleFighterDelegateEvent SquatEvent;
    
    /// <summary>
    /// Invokes the squat event.
    /// </summary>
    public void OnSquatEvent()
    {
        SquatEvent?.Invoke();
        if(debug) Debug.Log("Squat event invoked.");
    }
    
    /// <summary>
    /// Declares the punch event.
    /// </summary>
    public event SimpleFighterDelegateEvent PunchEvent;
    
    /// <summary>
    /// Invokes the punch event.
    /// </summary>
    public void OnPunchEvent()
    {
        PunchEvent?.Invoke();
        if(debug) Debug.Log("Punch event invoked.");
    }

    /// <summary>
    /// Declares the combo event.
    /// </summary>
    public event SimpleFighterDelegateEvent ComboEvent;
    
    /// <summary>
    /// Invokes the combo event.
    /// </summary>
    public void OnComboEvent()
    {
        ComboEvent?.Invoke();
        if(debug) Debug.Log("Combo event invoked.");
    }

    /// <summary>
    /// Declares the summon event.
    /// </summary>
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