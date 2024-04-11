using UnityEngine;

public class FighterBase : MonoBehaviour
{
    /// <summary>
    /// Delegates (haha) the required parameters events of this type must use
    /// All subscribers to this event must also having matching parameters
    /// </summary>
    public delegate void SimpleFighterDelegateEvent();

    /// <summary>
    /// Movement Events for Fighter Characters
    /// </summary>
    public event SimpleFighterDelegateEvent OnLeft;
    public void OnLeftMove()
    {
        OnLeft?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnRight;
    public void OnRightMove()
    {
        OnRight?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnJump;
    public void OnJumpMove()
    {
        OnJump?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnSquat;
    public void OnSquatMove()
    {
        OnSquat?.Invoke();
    }
    
    /// <summary>
    /// Attack Events for Fighter Characters
    /// </summary>
    public event SimpleFighterDelegateEvent OnPunch;
    public void OnPunchAttack()
    {
        OnPunch?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnKick;
    public void OnKickAttack()
    {
        OnKick?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnCombo;
    public void OnComboAttack()
    {
        OnCombo?.Invoke();
    }

    public event SimpleFighterDelegateEvent OnSummon;
    public void OnSummonAttack()
    {
        OnSummon?.Invoke();
    }
}