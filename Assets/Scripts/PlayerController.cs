using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement Controls
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    // Attack Controls
    public KeyCode attackPunch;
    public KeyCode attackKick;
    public KeyCode attackSpecial;
    public KeyCode attackUltimate;

    public float totalHealth;
    public float attackDamage;

    // Used to calculate what attack damage should be?
    public enum AttackTypes
    {
        Punch,
        Kick,
        Special,
        Ultimate
    }

    public float CalculateDamage(float currentDamage)
    {
        return currentDamage;
    }
    
    // Not sure if setting different control inputs would go here?
    public virtual void SetControls()
    {
        // Left
        // Right
        // Jump
        // Ult?
        // Ult 2? Special?
    }
}
