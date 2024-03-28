using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Player related
    [SerializeField]
    private float playerAcceleration = 5000f;

    // Bullet related
    private float bulletAcceleration = 200f;
    private float bulletInitialVelocity = 5f;

    // Rock related
    private float rockAceleration = 75f;
    private float rockInitialVelocity = 2f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Bullet related
        rb.velocity = Vector2.up * bulletInitialVelocity;

        // Rock related
        rb.velocity = Vector2.down * rockInitialVelocity;
    }

    // Player movements
    public void ShipMovement(float HorizontalInput)
    {
        Vector2 PlayerForceToAdd = Vector2.right * HorizontalInput * playerAcceleration * Time.deltaTime;
        rb.AddForce(PlayerForceToAdd);
    }

    // Update is called once per frame
    void Update()
    {
        // Bullet movement
        Vector2 BulletForceToAdd = Vector2.up * bulletAcceleration * Time.deltaTime;
        rb.AddForce(BulletForceToAdd);

        // Rock movement
        Vector2 RockForceToAdd = Vector2.down * rockAceleration * Time.deltaTime;
        rb.AddForce(RockForceToAdd);
    }
}
