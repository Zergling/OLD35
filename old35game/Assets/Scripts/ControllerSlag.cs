using UnityEngine;
using System.Collections;

public class ControllerSlag : MonoBehaviour {
    public GameObject Invis;
    public float maxSpeed = 10f;
    bool facingRight = true;

    public float move;
	// Use this for initialization
	void Start () {
        Invis.active = false;
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
    }
	void Update () {
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
    void OnCollisionEnter2D (Collision2D c)
    {
        if(c.collider.tag.Equals(Constants.GROUND_TAG))
        {
            c.collider.isTrigger = true;
            Invis.active = true;
        }
    }
}
