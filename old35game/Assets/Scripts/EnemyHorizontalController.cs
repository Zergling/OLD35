using UnityEngine;
using System.Collections;

public class EnemyHorizontalController : MonoBehaviour
{
    Vector3 position;
    public GameObject LeftWall;
    public GameObject RightWall;
    public float Speed;
    public float Direction;
    Vector3 LeftWallPoosition;
    Vector3 RightWallPosition;
	// Use this for initialization
	void Start ()
    {
        position = gameObject.transform.position;
        Direction = 1.0f;
        LeftWallPoosition = LeftWall.transform.position;
        RightWallPosition = RightWall.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        position.x += Speed * Direction;
        
        gameObject.transform.position = position;
        if (Direction > 0)
        {
            if (GetDistanceX(position, RightWallPosition) < 0.05f)
            {
                Direction *= -1;
            }
        }
        else
        {
            if (GetDistanceX(position, LeftWallPoosition) < 0.05f)
            {
                Direction *= -1;
            }
        }
        
	}

    float GetDistanceX(Vector3 mypos, Vector3 destpos)
    {
        float result = 0.0f;
        result = Mathf.Abs( destpos.x - mypos.x);
        return result;
    }
    
    void OnCollisionEnter2D (Collision2D c)
    {
        if (c.collider.tag.Equals(Constants.PLAYER_TAG))
        {
            Destroy(c.gameObject);
            Constants.PlayerDied = true;
        }
    }
}
