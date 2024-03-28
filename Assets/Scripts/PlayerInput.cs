using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;
    private Movement move;

    

    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
        move = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(HorizontalInput, 0);

        // Calls playermovement 
        if (HorizontalInput != 0.0f)
        {
            if (playerMovementScript != null)
            {
                move.ObjectMovement(HorizontalInput, direction);
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
