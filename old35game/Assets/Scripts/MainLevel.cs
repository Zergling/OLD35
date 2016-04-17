using UnityEngine;
using System.Collections;

public class MainLevel : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        /*
        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.Log("Go to TEST LEVEL");
            UnityEngine.SceneManagement.SceneManager.LoadScene("TestLevel");
        }
         * */

        if (Input.GetKeyUp(KeyCode.N) || Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            Constants.PlayerDied = false;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Training1");
        }
	}
}

static class Constants
{
    public static bool PlayerDied;
    public static string GROUND_TAG = "GROUND";
    public static string PLAYER_TAG = "PLAYER";
    public static Vector3 SpawnPosition;
    public static int Money = 0;
    public static string WALKER_POLYIMAGE = "WalkerPolyImage";
    public static string JUMPER_POLYIMAGE = "JumperPolyImage";
    public static string SMALLWALKER_POLYIMAGE = "SmallWalkerPolyImage";
    public static string WALLSLAGGER_POLYIMAGE = "WallSlaggerPolyImage";
    public static Vector2 DefaultGravity = new Vector2(Physics2D.gravity.x, Physics2D.gravity.y);

    public static void MakeGravityUp()
    {
        Physics2D.gravity = new Vector2(DefaultGravity.x, -DefaultGravity.y);
    }

    public static void MakeGravityDefault()
    {
        Physics2D.gravity = new Vector2(DefaultGravity.x, DefaultGravity.y);
    }

    public static void MakeGravityRight()
    {
        Physics2D.gravity = new Vector2(-DefaultGravity.y, DefaultGravity.x);
    }

    public static void MakeGravityLeft()
    {
        Physics2D.gravity = new Vector2(DefaultGravity.y, DefaultGravity.x);
    }
}
