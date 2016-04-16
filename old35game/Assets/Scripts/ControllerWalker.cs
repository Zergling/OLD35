using UnityEngine;
using System.Collections;

public class ControllerWalker : MonoBehaviour
{
    public float maxSpeed = 10f;
    bool facingRight = true;

    public float move;

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}