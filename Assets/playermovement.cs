using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D thisRigidbody2D;
    public float speed = 7f;

    Vector2 moveDirection;


   void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        thisRigidbody2D.MovePosition(thisRigidbody2D.position + moveDirection * speed * Time.fixedDeltaTime);
    }

    /*
    void ProcessInputs()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        ProcessInputs();
    }


    void Move()
    {
       thisRigidbody2D.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

        Move();
    }
    */
}

