using UnityEngine;
using System.Collections;

public class ControllerSlag2 : MonoBehaviour
{
    public float maxSpeed2 = 10f;
    bool facingRight2 = true;
    //Vector2 Gravi2;
    public float move2;
    // Use this for initialization
    void Start()
    {
        //Gravi2 = Physics2D.gravity;
        //Gravi2 = new Vector2(-100.0f,0f);
        Physics2D.gravity = new Vector2(-98f, 0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Gravi = new Vector2(-1.0f, -1.0f);
        move2 = Input.GetAxis("Horizontal");
        //Physics2D.gravity = Gravi2;
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move2 * maxSpeed2, GetComponent<Rigidbody2D>().velocity.y);

        if (move2 > 0 && !facingRight2)
            Flip2();
        else if (move2 < 0 && facingRight2)
            Flip2();
    }
    void GraviChange()
    {
        Physics2D.gravity = new Vector2(-1.0f, -1.0f);
    }

    void Flip2()
    {
        facingRight2 = !facingRight2;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
