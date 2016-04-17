using UnityEngine;
using System.Collections;

public class DeathField : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter2D (Collision2D c)
    {
        if (c.collider.tag.Equals(Constants.PLAYER_TAG))
        {
            Constants.PlayerDied = true;
            Destroy(c.gameObject);
        }
    }
}
