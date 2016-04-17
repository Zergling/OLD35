using UnityEngine;
using System.Collections;

public class ControllerSlag : MonoBehaviour {
    public float maxSpeed = 10f;
    bool facingRight = true;
    float Gravi;
    public float move;
	// Use this for initialization
	void Start () {
        Gravi = gameObject.GetComponent<Rigidbody2D>().gravityScale;
        Gravi *= -1;
        //Physics2D.gravity;
       // Gravi = new Vector2(-1.0f,-1.0f);

	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        //Gravi = new Vector2(-1.0f, -1.0f);
        move = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().gravityScale
        /*Physics2D.gravity*/ = Gravi;
    }
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}
    void GraviChange()
    {
        Physics2D.gravity = new Vector2(-1.0f, -1.0f);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
