using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D rigidbody2d;

    private Vector2 moveDirection;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ProcessInput();
    }

    private void FixedUpdate()
    {
        ApplyMovementForces();
    }

    private void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void ApplyMovementForces()
    {
        rigidbody2d.velocity = new Vector2(movementSpeed * moveDirection.x, movementSpeed * moveDirection.y);
    }

}
