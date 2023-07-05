using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float movementX;
    float movementY;
    bool jump;
    public float velocity = 100f;
    public float jumpForce = 5f;     
    public Rigidbody2D rb;
    
    bool facingRight = true;

    public Animator animator;
    
    bool isGrounded = true;
    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col) //1
    {
         if(col.gameObject.tag == "Ground") 
         {   isGrounded = true;
            jump = false;
            animator.SetBool("jump",jump);
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        movementY = rb.velocity.y;
        animator.SetFloat("movementX", movementX);   
        animator.SetFloat("movementY", movementY); 

        
        rb.velocity = new Vector2(movementX * velocity * Time.fixedDeltaTime, rb.velocity.y);
        if(Input.GetButtonDown("Jump") && isGrounded && jump == false) {
            jump = true;
            animator.SetBool("jump",jump);
            isGrounded = false;
            rb.velocity = Vector2.up * jumpForce; 
             }
        if(movementX<0 && facingRight == true) {

            transform.Rotate(0, 180, 0);
            facingRight = false;
        }
    
        else if(movementX>0 && facingRight == false)       
        {      
            transform.Rotate(0, 180, 0);
            facingRight = true;
        } 
    }
    void FixedUpdate() {
        rb.velocity = new Vector2(movementX * velocity * Time.fixedDeltaTime, rb.velocity.y);
    }
}