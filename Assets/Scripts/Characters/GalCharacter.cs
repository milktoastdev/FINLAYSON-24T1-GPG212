using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GalCharacter : SerializedMonoBehaviour, ICharacter, IHealth
{
    // Magic user! Doesn't use melee attacks :0
    // Can summon creatures?

    public string GetName(string myName)
    {
        myName = "Gal";
        
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
