using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode leftMove;
    public KeyCode rightMove;
    public KeyCode jumpMove;
    public KeyCode duckMove;

    public float moveSpeed = 5.0f;
    
    void OnEnable()
    {
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(leftMove))
        {
            transform.Translate(Vector3.left * moveSpeed);
            // Left moving animation
        }
        
        if (Input.GetKeyDown(rightMove))
        {
            transform.Translate(Vector3.right * moveSpeed);
            // Right moving animation
        }

        // This probably won't work the way I want unless I fix the player mass
        if (Input.GetKeyDown(jumpMove))
        {
            transform.Translate(Vector3.up * moveSpeed);
            // Jump animation
        }
        
        // Duck animation
        // Hitbox squash or move downward??
    }

    void FixedUpdate()
    {
    }

    void OnDisable()
    {
    }
}
