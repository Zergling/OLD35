using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {
    float i;
	// Use this for initialization
	void Start () {
        i = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        i += Time.deltaTime;
        transform.position = new Vector3(transform.position.x, Mathf.Sin(i * 6.9f) / 20 + transform.position.y, transform.position.z);
	}
    void OnCollisionEnter2D (Collision2D c)
    {
        if (c.collider.tag.Equals("PLAYER"))
        {
            Constants.Money++;
        }
    }
}
