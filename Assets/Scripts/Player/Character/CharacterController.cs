using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // *** THIS NEEDS TO BE CHANGED NOW ***
    // Poultry will not have the same attack types as the main characters
    // *screams in modularity*
    
    // Movement Controls
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveJump;
    public KeyCode moveSquat;
    public float moveSpeed;
    
    // Attack Controls
    public KeyCode attackPunch;
    public KeyCode attackKick;
    public KeyCode attackSpecial;
    public KeyCode attackUltimate;
    public float totalHealth;
    public float attackDamage;

    public CharacterBase characterbase;
    
    public void OnEnable()
    {
        // Subscribing to attack events ("setting up")
        characterbase.OnPunch += PunchAttack;
        characterbase.OnKick += KickAttack;
        characterbase.OnSpecial += SpecialAttack;
        characterbase.OnUltimate += UltimateAttack;
    }

    public void OnDisable()
    {
        // Unsubscribing from attack events ("cleaning up")
        characterbase.OnPunch -= PunchAttack;
        characterbase.OnKick -= KickAttack;
        characterbase.OnSpecial -= SpecialAttack;
        characterbase.OnUltimate -= UltimateAttack;
    }

    public void PunchAttack()
    {
        Debug.Log("I punched!");
    }

    public void KickAttack()
    {
        Debug.Log("I kicked!");
    }

    public void SpecialAttack()
    {
        Debug.Log("I specialed!");
    }

    public void UltimateAttack()
    {
        Debug.Log("I ultimated!");
    }
    
    // Default control inputs, able to be overriden by different players
    // IDK if this is the best way to do this
    public virtual void SetControls()
    {
        // Movement Controls
        moveLeft = KeyCode.A;
        moveRight = KeyCode.S;
        moveJump = KeyCode.W;
        moveSquat = KeyCode.S;
        // P2 : LArrow, RArrow, UArrow, DArrow
        
        // Attack Controls
        attackPunch = KeyCode.Alpha4;
        attackKick = KeyCode.Alpha5;
        attackSpecial = KeyCode.Alpha6;
        attackUltimate = KeyCode.Alpha7;
        // P2 : 9, 0, -, =
    }

    private void Update()
    {
        // Movement Inputs
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * moveSpeed);
        }
        
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * moveSpeed);
        }
        
        // Needs && vertical position is not in the air / is not moving up or down?
        // I DONT KNOW
        if (Input.GetKeyDown(moveJump))
        {
            transform.Translate(Vector3.up * moveSpeed);
        }
        
        if (Input.GetKey(moveSquat))
        {
            Debug.Log("I'm squatting :)");
        }

        // Attack Inputs
        if (Input.GetKeyDown(attackPunch))
        {
            PunchAttack();
        }
        
        if (Input.GetKeyDown(attackKick))
        {
            KickAttack();
        }
        
        if (Input.GetKeyDown(attackSpecial))
        {
            SpecialAttack();
        }
        
        if (Input.GetKeyDown(attackUltimate))
        {
            UltimateAttack();
        }
    }

    /*
    // Not using this right now
    // Might not be necessary tbh
    public float CalculateDamage(float currentDamage)
    {
        return currentDamage;
    }
    */
}
