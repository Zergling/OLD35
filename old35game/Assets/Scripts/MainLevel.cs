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
        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.Log("Go to TEST LEVEL");
            UnityEngine.SceneManagement.SceneManager.LoadScene("TestLevel");
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
}
