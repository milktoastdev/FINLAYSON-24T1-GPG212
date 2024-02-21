using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    // Delegates the required parameters events of this type must use
    // All subscribers to this even must have matching parameters
    // I think?
    public delegate void SimpleDelegateEvent();

    // Attack type events
    public event SimpleDelegateEvent OnPunch;
    public event SimpleDelegateEvent OnKick;
    public event SimpleDelegateEvent OnSpecial;
    public event SimpleDelegateEvent OnUltimate;
    
    public void OnPunchAttack()
    {
        OnPunch?.Invoke();
    }

    public void OnKickAttack()
    {
        OnKick?.Invoke();
    }

    public void OnSpecialAttack()
    {
        OnSpecial?.Invoke();
    }

    public void OnUltimateAttack()
    {
        OnUltimate?.Invoke();
    }
}