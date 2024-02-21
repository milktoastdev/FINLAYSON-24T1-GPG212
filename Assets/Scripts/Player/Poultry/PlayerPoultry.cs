using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerPoultry : SerializedMonoBehaviour, IIdentity, IHealth
{
    public PoultryBase poultryBase;

    public KeyCode attackPeck;
    
    public void OnEnable()
    {
        // Subscribing ("setting up")
        poultryBase.OnPeck += PeckAttack;
    }

    private void PeckAttack()
    {
        Debug.Log("I pecked!");
    }

    public void OnDisable()
    {
        // Unsubscribing ("cleaning up")
        poultryBase.OnPeck -= PeckAttack;
    }

    public string GetName(string myName)
    {
        return myName;
    }

    public string GetType(string myType)
    {
        myType = "Poultry";
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

    public void Damaged(float amount)
    {
        // Calculate Damage
        // Apply Damage
    }

    public void Healed(float amount)
    {
        // Calculate Healing
        // Apply healing
    }

    public void Defeated()
    {
        Destroy(gameObject);
    }
}
