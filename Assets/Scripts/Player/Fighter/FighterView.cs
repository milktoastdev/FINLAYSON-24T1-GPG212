using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Representation of the fighter to the player.
/// Has no impact on gameplay.
/// </summary>
public class FighterView : MonoBehaviour
{
    /// <summary>
    /// Debug.Logs are written when this is true.
    /// </summary>
    public bool debug;
    
    /// <summary>
    /// Refers to the fighter script in the inspector.
    /// </summary>
    public FighterBase fighterBase;
    
    /// <summary>
    /// Each part of the sprite is separated for colouring & tweening (animation) purposes.
    /// </summary>
    public SpriteRenderer fillSpriteRenderer; 
    public SpriteRenderer bodySpriteRenderer;
    public SpriteRenderer eyeSpriteRenderer;

    // Body colour sprites.
    public Sprite fillSprite;
    public Sprite squatFillSprite;
    // Body outline sprites.
    public Sprite bodySprite;
    public Sprite squatBodySprite;
    // Eye sprites.
    // TODO: Perlin noise while idle x2: 1 for blinking, the other for eye movement (direction & lingering time)
    public Sprite eyeSprite;
    public Sprite squatEyeSprite;
    public Sprite jumpEyeSprite;
    
    /// <summary>
    /// The player can change this at the beginning of the match.
    /// Players cannot have the same colour.
    /// Colour options can be found in FighterBase.
    /// </summary>
    public Color fillColour;

    // These are placeholders for movement testing!
    public Color fighterIdleColor;
    public Color fighterLeftColor;
    public Color fighterRightColor;
    public Color fighterJumpColor;
    public Color fighterSquatColor;

    public void OnEnable()
    {
        if(debug)
        {
            // Resetting sprite to default colour.
            fillSpriteRenderer.color = fighterIdleColor;
            Debug.Log("VIEW is enabled.");
        }
        
        // Subscribing to movement events ("setting up")
        fighterBase.LeftEvent += OnLeftEvent;
        fighterBase.RightEvent += OnRightEvent;
        fighterBase.JumpEvent += OnJumpEvent;
        fighterBase.SquatEvent += OnSquatEvent;
    }
    
    public void OnLeftEvent()
    {
        // TODO: Eyes move left
        
        if (debug)
        {
            fillSpriteRenderer.color = fighterLeftColor;
            Debug.Log("VIEW is moving left.");
        }
    }

    public void OnRightEvent()
    {
        // TODO: Eyes move right
        
        if (debug)
        {
            fillSpriteRenderer.color = fighterRightColor;
            Debug.Log("VIEW is moving right.");
        }
    }

    public void OnJumpEvent()
    {
        eyeSpriteRenderer.sprite = jumpEyeSprite;
        
        // TODO: Swap eyes back to regular eyes on collision with the floor
        
        if (debug)
        {
            fillSpriteRenderer.color = fighterJumpColor;
            Debug.Log("VIEW is jumping.");
        }
    }

    public void OnSquatEvent()
    {
        // TODO: Swap body sprite, eye sprite & fill sprite. Change size of collider.
        
        if (debug)
        {
            fillSpriteRenderer.color = fighterSquatColor;
            Debug.Log("VIEW is squatting.");
        }
    }

    public void OnDisable()
    {
        // Unsubscribing from movement events ("cleaning up")
        fighterBase.LeftEvent -= OnLeftEvent;
        fighterBase.RightEvent -= OnRightEvent;
        fighterBase.JumpEvent -= OnJumpEvent;
        fighterBase.SquatEvent -= OnSquatEvent;

        if (debug)
        {
            // Resetting sprite to default colour.
            fillSpriteRenderer.color = fighterIdleColor;
            Debug.Log("VIEW is disabled.");
        }
    }
}