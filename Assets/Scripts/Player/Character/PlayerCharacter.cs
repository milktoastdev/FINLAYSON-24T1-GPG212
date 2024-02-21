using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerCharacter : SerializedMonoBehaviour, IIdentity, IHealth
{
    public CharacterBase characterBase;
    
    // Attack Controls
    public KeyCode attackPunch;
    public KeyCode attackKick;
    public KeyCode attackSpecial;
    public KeyCode attackUltimate;
    
    public void OnEnable()
    {
        // Subscribing ("setting up")
        characterBase.OnPunch += PunchAttack;
        characterBase.OnKick += KickAttack;
        characterBase.OnSpecial += SpecialAttack;
        characterBase.OnUltimate += UltimateAttack;
    }
    
    // I'm just chucking this here for now
    // Attack Controls
    // attackPunch = KeyCode.Alpha4;
    // attackKick = KeyCode.Alpha5;
    // attackSpecial = KeyCode.Alpha6;
    // attackUltimate = KeyCode.Alpha7;
    // P2 : 9, 0, -, =
    
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

    public void Update()
    {
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

    public void OnDisable()
    {
        // Unsubscribing ("cleaning up")
        characterBase.OnPunch -= PunchAttack;
        characterBase.OnKick -= KickAttack;
        characterBase.OnSpecial -= SpecialAttack;
        characterBase.OnUltimate -= UltimateAttack;
    }
    
    public string GetName(string myName)
    {
        // This will pull from a database of some type that holds character names & all their details when they are spawned
        return myName;
    }

    public string GetType(string myType)
    {
        myType = "Character";
        return myType;
    }

    public int GetPlayer(int myPlayer)
    {
        return myPlayer;
    }

    public void SetHealth(float health)
    {
    }

    public void GetHealth(float health)
    {
    }

    public void Damaged(float amountDamage)
    {
        // Calculate Damage
        // Apply Damage
    }

    public void Healed(float amountHeal)
    {
        // Calculate Healing
        // Apply healing
    }
    
    public void Defeated()
    {
        Destroy(gameObject);
    }
}
