using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private ShootingScript shootingScript;
    private Movement move;

    private float acceleration = 5000f;

    // Start is called before the first frame update
    void Start()
    {
        shootingScript = GetComponent<ShootingScript>();
        move = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input
        float HorizontalInput = Input.GetAxis("Horizontal");

        // Turn input into direction
        Vector2 direction = new Vector2(HorizontalInput, 0);

         
        if (HorizontalInput != 0.0f)
        {
            if (move != null)
            {
                // Calls Movement script
                move.ObjectMovement(direction, acceleration);
            }
            else
            {
                Debug.Log("Attach the player movement script");
            }
        }

        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                Debug.Log("Attach the shooting script");
            }
        }
    }


}
