using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GirlCharacter : SerializedMonoBehaviour, ICharacter, IHealth
{
    // Melee only! No ranged attacks

    public string GetName(string myName)
    {
        myName = "Girl";
        
        return myName;
    }

    public void SetHealth(float health)
    {
    }

    public void GetHealth(float health)
    {
    }

    public void Damaged(float amountDamage)
    {
    }

    public void Healed(float amountHeal)
    {
    }
    
    public void Defeated()
    {
        Destroy(gameObject);
    }
}
