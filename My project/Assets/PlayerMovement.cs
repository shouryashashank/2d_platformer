using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public float Move;
    public float jump;
    public bool isJumping;
    public int jumpCounter = 0; 
    public int maxJump;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        if(Input.GetButtonDown("Jump") && (isJumping == false || jumpCounter < maxJump) ){
            jumpCounter++;
            rb.AddForce(new Vector2(rb.velocity.x,jump));
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")){
            isJumping = false; 
            jumpCounter = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")){
            isJumping = true; 
        }
    }
}
