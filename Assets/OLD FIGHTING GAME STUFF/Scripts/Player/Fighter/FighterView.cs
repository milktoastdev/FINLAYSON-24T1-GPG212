using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterView : MonoBehaviour
{
    public bool debug;
    
    public FighterBase fighterBase;
    
    public SpriteRenderer spriteRenderer;

    // These are placeholders for final sprites
    public Color fighterIdleColor;
    public Color fighterLeftColor;
    public Color fighterRightColor;
    public Color fighterJumpColor;
    public Color fighterSquatColor;

    public void OnEnable()
    {
        debug = true;
        
        // Resetting sprite to default colour
        spriteRenderer.color = fighterIdleColor;
        
        // Subscribing to movement events ("setting up")
        fighterBase.OnLeft += LeftMove;
        fighterBase.OnRight += RightMove;
        fighterBase.OnJump += JumpMove;
        fighterBase.OnSquat += SquatMove;
    }
    
    // These could be controlled through a ChangeColor(Color newColor) function
    // I'm just doing hardcoded bullshit to make it work for now
    public void LeftMove()
    {
        spriteRenderer.color = fighterLeftColor;
    }

    public void RightMove()
    {
        spriteRenderer.color = fighterRightColor;
    }

    public void JumpMove()
    {
        spriteRenderer.color = fighterJumpColor;
    }

    public void SquatMove()
    {
        // Cube squish!
        // Either change the cube's dimensions or swap the renderer, collider, etc. out
        spriteRenderer.color = fighterSquatColor;
    }

    public void OnDisable()
    {
        // Unsubscribing from movement events ("cleaning up")
        fighterBase.OnLeft -= LeftMove;
        fighterBase.OnRight -= RightMove;
        fighterBase.OnJump -= JumpMove;
        fighterBase.OnSquat -= SquatMove;

        // Resetting sprite to default colour
        spriteRenderer.color = fighterIdleColor;

        debug = false;
    }
}
