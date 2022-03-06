using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D playerRigi;

    float mx;
    float my;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * playerSpeed, my * playerSpeed);

        playerRigi.velocity = movement;
    }
}