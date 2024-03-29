using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ObjectMovement(Vector2 direction, float acceleration)
    {
        Vector2 movement = direction * acceleration * Time.deltaTime;
        rb.AddForce(movement);

        //Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
        //rb.AddForce(ForceToAdd);
    }

    private void Update()
    {
        
    }
}
