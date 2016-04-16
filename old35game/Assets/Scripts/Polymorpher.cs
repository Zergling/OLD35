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
            Vector3 position = gameObject.transform.position;
            string path = selector.GetPolymorph();
            Debug.Log(path);
            GameObject poly = Resources.Load(path, typeof(GameObject)) as GameObject;
            if (poly == null)
            {
                Debug.Log("cant load");
            }
            else
            {
                Instantiate(poly, position, Quaternion.identity);
                Destroy(gameObject);
            }
        }

        /*
         * полиморф назад
        if (Input.GetKeyUp(KeyCode.Backspace) || Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            Debug.Log("hsp");
        }
         */
	}
}
