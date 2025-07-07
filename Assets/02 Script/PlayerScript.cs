using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerScript : MonoBehaviour

{
    public static PlayerScript remainPlayer;
    void Awake() {
        if (remainPlayer == null) {
            remainPlayer = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        } 
    }
    public float speed = 5f;
    public float jumpForce = 10f;
    Rigidbody2D rb;
    Animator animator;
    bool isGrounded = false;
    private float moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0 && transform.localScale.x < 0) {
            FlipSprite();
        }
        if (moveInput < 0 && transform.localScale.x > 0) {
            FlipSprite();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.velocity =  new Vector2(rb.velocity.x,jumpForce);
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
        }
    }
    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.x);

    }
    void FlipSprite() {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", !isGrounded);
    }
}

