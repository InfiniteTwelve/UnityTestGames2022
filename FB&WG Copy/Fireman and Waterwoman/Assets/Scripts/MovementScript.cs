using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float movementSpeed;
    public Rigidbody2D rb;

    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;

    public int playerNumber;



    float mx;

    private void Update()
    {
        if (playerNumber == 0)
        {
            mx = Input.GetAxisRaw("HorizontalOne");
            if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
            {
                Jump();
            }
        } else if (playerNumber == 1)
        {
            mx = Input.GetAxisRaw("HorizontalTwo");
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {
                Jump();
            }
        }
    }


    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);


        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        Debug.Log("Is Grounded? " + groundCheck);


        if (groundCheck != null)
        {
            return true;
        }

        return false;
    }
}
