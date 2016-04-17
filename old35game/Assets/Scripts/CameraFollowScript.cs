using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour
{
    GameObject player;
	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        player = GameObject.FindGameObjectWithTag(Constants.PLAYER_TAG);
        if (player != null)
        {
            Vector3 newpos = player.transform.position;
            newpos.z = -10;
            transform.position = newpos;
        }
        
	}
}
