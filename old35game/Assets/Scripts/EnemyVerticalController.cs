using UnityEngine;
using System.Collections;

public class EnemyVerticalController : MonoBehaviour
{
    Vector3 position;
    public GameObject UpWall;
    public GameObject DownWall;
    public float Speed;
    public float Direction;
    Vector3 DownWallPoosition;
    Vector3 UpWallPosition;
	// Use this for initialization
	void Start ()
    {
        position = gameObject.transform.position;
        Direction = 1.0f;
        UpWallPosition = UpWall.transform.position;
        DownWallPoosition = DownWall.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        position.y += Speed * Direction;

        gameObject.transform.position = position;
        if (Direction > 0)
        {
            if (GetDistanceY(position, UpWallPosition) < 0.05f)
            {
                Direction *= -1;
            }
        }
        else
        {
            if (GetDistanceY(position, DownWallPoosition) < 0.05f)
            {
                Direction *= -1;
            }
        }
	}

    float GetDistanceY(Vector3 mypos, Vector3 destpos)
    {
        float result = 0.0f;
        result = Mathf.Abs(destpos.y - mypos.y);
        return result;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.tag.Equals(Constants.PLAYER_TAG))
        {
            Destroy(c.gameObject);
            Constants.PlayerDied = true;
        }
    }
}
