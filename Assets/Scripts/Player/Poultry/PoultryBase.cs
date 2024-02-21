using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoultryBase : MonoBehaviour
{
    public delegate void SimplePoultryDelegateEvent();

    public event SimplePoultryDelegateEvent OnPeck;

    public void OnPeckAttack()
    {
        OnPeck?.Invoke();
    }
}
