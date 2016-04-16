using UnityEngine;
using System.Collections;

public class Polymorpher : MonoBehaviour 
{
    SelectorScript selector;
	// Use this for initialization
	void Start () 
    {
        selector = GameObject.Find("Selector").GetComponent<SelectorScript>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.Joystick1Button3))
        {
            Debug.Log("psh");
        }
	}
}
