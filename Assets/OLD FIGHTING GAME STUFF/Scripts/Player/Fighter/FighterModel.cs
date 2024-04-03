using UnityEngine;

public enum FighterCharacters
{
    Placeholder0,
    Placeholder1
}

public class FighterModel : MonoBehaviour
{
    public bool debug;
    
    public FighterBase fighterBase;
    
    public void OnEnable()
    {
        debug = true;
        
        // Subscribing to movement events ("setting up")
        fighterBase.OnLeft += LeftMove;
        fighterBase.OnRight += RightMove;
        fighterBase.OnJump += JumpMove;
        fighterBase.OnSquat += SquatMove;
        
        // Subscribing to attack events ("setting up")
        fighterBase.OnPunch += PunchAttack;
        fighterBase.OnKick += KickAttack;
        fighterBase.OnCombo += ComboAttack;
        fighterBase.OnSummon += SummonAttack;
    }

    /// <summary>
    /// Movement Event Functions
    /// </summary>
    public void LeftMove()
    {
        if(debug) Debug.Log("Moving left!");
    }

    public void RightMove()
    {
        if(debug) Debug.Log("Moving right!");
    }

    public void JumpMove()
    {
        if(debug) Debug.Log("Jumping!");
    }

    public void SquatMove()
    {
        if(debug) Debug.Log("Squatting!");
    }
    
    /// <summary>
    /// Attack Event Functions
    /// </summary>
    public void PunchAttack()
    {
        if(debug) Debug.Log("I punched!");
    }

    public void KickAttack()
    {
        if(debug) Debug.Log("I kicked!");
    }

    public void ComboAttack()
    {
        if(debug) Debug.Log("I combo-ed!");
    }

    public void SummonAttack()
    {
        if(debug) Debug.Log("I summoned!");
    }

    public void OnDisable()
    {
        // Unsubscribing from movement events ("cleaning up")
        fighterBase.OnLeft -= LeftMove;
        fighterBase.OnRight -= RightMove;
        fighterBase.OnJump -= JumpMove;
        fighterBase.OnSquat -= SquatMove;
        
        // Unsubscribing from attack events ("cleaning up")
        fighterBase.OnPunch -= PunchAttack;
        fighterBase.OnKick -= KickAttack;
        fighterBase.OnCombo -= ComboAttack;
        fighterBase.OnSummon -= SummonAttack;

        debug = false;
    }
}
