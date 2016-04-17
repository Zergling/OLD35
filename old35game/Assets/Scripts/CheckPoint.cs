using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour 
{
    public GameObject spawnPoint;
    bool iWorking;
	// Use this for initialization
	void Start () 
    {
        iWorking = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Constants.PlayerDied == true && iWorking == true)
        {
            GameObject newPlayer = Resources.Load("Walker", typeof(GameObject)) as GameObject;
            Instantiate(newPlayer, Constants.SpawnPosition, Quaternion.identity);
            Constants.PlayerDied = false;
        }
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag.Equals(Constants.PLAYER_TAG))
        {
            Constants.SpawnPosition = spawnPoint.transform.position;
            iWorking = true;
            Debug.Log("Checkpoint");
        }
    }
}
