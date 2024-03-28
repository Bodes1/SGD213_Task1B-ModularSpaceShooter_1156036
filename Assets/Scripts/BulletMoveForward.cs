using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour
{

    private float bulletAcceleration = 200f;

    private float bulletInitialVelocity = 5f;

    private Rigidbody2D rb;

  

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.up * bulletInitialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ForceToAdd = Vector2.up * bulletAcceleration * Time.deltaTime;

        rb.AddForce(ForceToAdd);
    }
}
