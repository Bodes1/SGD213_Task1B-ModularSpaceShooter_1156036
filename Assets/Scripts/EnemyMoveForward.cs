using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class EnemyMoveForward : MonoBehaviour
{
    private Movement move;

    private float acceleration = 75f;

    private float rockInitialVelocity = 2f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        move = GetComponent<Movement>();

        rb.velocity = Vector2.down * rockInitialVelocity;        
    }

    void Update()
    {
        Vector2 direction = new Vector2(0, -1);

        move.ObjectMovement(direction, acceleration);

        //Vector2 RockForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        //rb.AddForce(RockForceToAdd);
    }
}
