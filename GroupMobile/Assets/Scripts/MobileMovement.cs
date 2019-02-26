using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public bool grounded = false;
    public float moveDir = 0;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Calling velocity, setting it to x-axis, returning it so player can move along x-axis.
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveSpeed * moveDir;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    public void MoveRight()
    {
        moveDir = 1;
    }

    public void MoveLeft()
    {
        moveDir = -1;
    }

    public void Stop()
    {
        moveDir = 0;
    }

    public void Jump()
    {
        if(grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        { 
            GetComponent<Animator>().SetBool("Grounded", true);
            grounded = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            GetComponent<Animator>().SetBool("Grounded", false);
            grounded = false;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            GetComponent<Animator>().SetBool("Grounded", true);
            grounded = true;
        }
    }
}
