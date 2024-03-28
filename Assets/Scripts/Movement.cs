using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 5000f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ObjectMovement(float HorizontalInput, Vector2 direction)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }

    private void Update()
    {
        
    }
}
