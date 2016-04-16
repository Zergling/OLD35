using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float jumpForce = 700f;
    bool facingRight = true;
    bool grounded;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;

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
        if (grounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void OnCollisionEnter2D (Collision2D c)
    {
        if (c.collider.tag.Equals(Constants.GROUND_TAG))
        {
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
}