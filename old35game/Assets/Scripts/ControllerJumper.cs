﻿using UnityEngine;
using System.Collections;

public class ControllerJumper : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float jumpForce = 700f;
    bool facingRight = true;
    bool grounded;
    public float move;

    // Use this for initialization
    void Start()
    {
        grounded = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }

        if (move < 0 && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }
    }

    void OnCollisionEnter2D (Collision2D c)
    {
        if (c.collider.tag.Equals(Constants.GROUND_TAG))
        {
            move = 0;
            grounded = true;
            Debug.Log(grounded);
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        grounded = false;
        Debug.Log(grounded);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

static class Constants
{
    public static string GROUND_TAG = "GROUND";
<<<<<<< HEAD
    public static int Money = 0;
=======
    public static string WALKER_POLYIMAGE = "WalkerPolyImage";
    public static string JUMPER_POLYIMAGE = "JumperPolyImage";
    public static string SMALLWALKER_POLYIMAGE = "SmallWalkerPolyImage";
>>>>>>> e43e6db586a1b6d86f389dce715b481158c86d30
}