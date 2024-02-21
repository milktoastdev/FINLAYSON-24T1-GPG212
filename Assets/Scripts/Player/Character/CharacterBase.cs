using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    // Delegates the required parameters events of this type must use
    // All subscribers to this even must have matching parameters
    // I think?
    public delegate void SimpleCharacterDelegateEvent();

    // Attack type events
    public event SimpleCharacterDelegateEvent OnPunch;
    public event SimpleCharacterDelegateEvent OnKick;
    public event SimpleCharacterDelegateEvent OnSpecial;
    public event SimpleCharacterDelegateEvent OnUltimate;
    
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