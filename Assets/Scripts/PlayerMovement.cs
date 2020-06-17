using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;


    public Rigidbody2D rb;
    public Animator animator;


    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //INPUT
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("New Float 0", movement.sqrMagnitude);
    }


    void FixedUpdate()
    {
        //MOVEMENT

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
