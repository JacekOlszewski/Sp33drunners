using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float maxSpeed = 10f;
    bool facingRight = true;
    bool grounded = false;
    Collider2D coll;
    public int jumpForce = 1000;

    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 contactPoint = collision.contacts[0].point;
        Collider2D collider = collision.collider;
        Vector3 center = collider.bounds.center;
        bool bottom = contactPoint.y < center.y;
        if (!bottom) grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}
