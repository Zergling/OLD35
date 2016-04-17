using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour 
{
    public string NextLevel;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter2D (Collider2D c)
    {
        if (c.tag.Equals(Constants.PLAYER_TAG))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextLevel);
        }
    }
}
