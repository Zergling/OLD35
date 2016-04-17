using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour 
{
    public string NextLevel;
    public float RotationSpeed;
	// Use this for initialization
	void Start ()
    {
        if (RotationSpeed > 0)
        {
            RotationSpeed *= -1;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(0, 0, RotationSpeed);
	}

    void OnTriggerEnter2D (Collider2D c)
    {
        if (c.tag.Equals(Constants.PLAYER_TAG))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextLevel);
        }
    }
}
