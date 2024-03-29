using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public enum DirectionList
{
    PlayerDirection,
    BulletDirection,
    RockDirection
}

public class Movement : MonoBehaviour
{
    // List to know what object needs
    [SerializeField]
    private DirectionList directionList = DirectionList.PlayerDirection;

    private Rigidbody2D rb;

    // Set values to zero
    private float acceleration = 0f;
    private float initialVelocity = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Rock initialVelocity and acceleration
        if (directionList == DirectionList.RockDirection)
        {
            acceleration = 75f;
            initialVelocity = 2f;

            rb.velocity = Vector2.down * initialVelocity;
        }

        // Bullet initialVelocity and acceleration
        if (directionList == DirectionList.BulletDirection)
        {
            acceleration = 200f;
            initialVelocity = 5f;

            rb.velocity = Vector2.up * initialVelocity;
        }

        // Does nothing due to it coming from PlayerInput, just here to stop the blank error
        if (directionList == DirectionList.PlayerDirection) 
        {

        }
    }

    private void Update()
    {
        // Rock movement
        if (directionList == DirectionList.RockDirection)
        {
            Vector2 RockForceToAdd = Vector2.down * acceleration * Time.deltaTime;
            rb.AddForce(RockForceToAdd);
        }

        // Bullet movement
        if (directionList == DirectionList.BulletDirection)
        {
            Vector2 BulletForceToAdd = Vector2.up * acceleration * Time.deltaTime;
            rb.AddForce(BulletForceToAdd);
        }
    }

    // Player movement
    public void ObjectMovement(Vector2 direction, float acceleration)
    {
        Vector2 Movement = direction * acceleration * Time.deltaTime;
        rb.AddForce(Movement);
    }
}
