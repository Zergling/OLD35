using UnityEngine;
using System.Collections;

public class ControllerSlag2 : MonoBehaviour
{
    public float maxSpeed2 = 10f;
    bool facingRight2 = true;
    //Vector2 Gravi2;
    public float move2;
    bool gravityRight;
    // Use this for initialization
    void Start()
    {
        Constants.PlayerDied = false;
        Constants.MakeGravityRight();
        gravityRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Gravi = new Vector2(-1.0f, -1.0f);
        move2 = Input.GetAxis("Vertical");
        //Physics2D.gravity = Gravi2;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Backspace) || Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            if (gravityRight == true)
            {
                gravityRight = false;
                Constants.MakeGravityLeft();
            }
            else
            {
                gravityRight = true;
                Constants.MakeGravityRight();
            }
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, move2 * maxSpeed2);
    }

    void Flip2()
    {
        facingRight2 = !facingRight2;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
