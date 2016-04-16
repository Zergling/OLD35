using UnityEngine;
using System.Collections;

public class SelectorScript : MonoBehaviour
{
    int select;
    int selectMax;
    string[] selections;
	// Use this for initialization
	void Start ()
    {
        selectMax = 3;
        selections = new string[selectMax];
        selections[0] = Constants.WALKER_POLYIMAGE;
        selections[1] = Constants.JUMPER_POLYIMAGE;
        selections[2] = Constants.SMALLWALKER_POLYIMAGE;

        select = 0;

        GameObject obj = GameObject.Find(selections[select]);
        gameObject.transform.position = obj.transform.position;
	}

    int CheckSelect(int number, int max)
    {
        int x = number;

        if (x >= max)
        {
            x = 0;
        }

        if (x < 0)
        {
            x = max - 1;
        }

        return x;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyUp(KeyCode.PageDown))
        {
            select--;
            select = CheckSelect(select, selectMax);

            GameObject obj = GameObject.Find(selections[select]);
            gameObject.transform.position = obj.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.PageUp))
        {
            select++;
            select = CheckSelect(select, selectMax);

            GameObject obj = GameObject.Find(selections[select]);
            gameObject.transform.position = obj.transform.position;
        }


	}
}
