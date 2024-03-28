using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class EnemyMoveForward : MonoBehaviour
{
    private float rockAceleration = 75f;

    private float rockInitialVelocity = 2f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.down * rockInitialVelocity;
    }

    void Update()
    {
        Vector2 RockForceToAdd = Vector2.down * rockAceleration * Time.deltaTime;

        rb.AddForce(RockForceToAdd);
    }
}
