using UnityEngine;
using System.Collections;

public class ControllerJumper : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float jumpForce = 200f;
    bool facingRight = true;
    bool grounded;
    public float move;

    // Use this for initialization
    void Start()
    {
        grounded = false;
        Constants.PlayerDied = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move != 0 && grounded)
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
    public static bool PlayerDied;
    public static string GROUND_TAG = "GROUND";
<<<<<<< HEAD
=======
    public static string PLAYER_TAG = "PLAYER";
    public static Vector3 SpawnPosition;
    public static int Money = 0;
>>>>>>> 90439fa57ce3591bc87dcb8c575dea7853d4372f
    public static string WALKER_POLYIMAGE = "WalkerPolyImage";
    public static string JUMPER_POLYIMAGE = "JumperPolyImage";
    public static string SMALLWALKER_POLYIMAGE = "SmallWalkerPolyImage";
}