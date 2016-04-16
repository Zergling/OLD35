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
