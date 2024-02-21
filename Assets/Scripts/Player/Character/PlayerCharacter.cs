using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerCharacter : SerializedMonoBehaviour, IIdentity, IHealth
{
    public void OnEnable()
    {
        
    }

    public void OnDisable()
    {
        
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
