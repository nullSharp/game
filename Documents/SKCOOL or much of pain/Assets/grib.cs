using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grib : MonoBehaviour {
    private int tick = 0;
    private string go = "up";
    // Use this for insitialization
	void Start ()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (go == "up")
        {
            tick++;
            transform.Translate(0, 1, 0);
            if(tick > 5)
            {
                go = null;
                StartCoroutine(Timer(1));
            }
        }
        if (go == "down")
        {
            tick++;
            transform.Translate(0, -1, 0);
            if (tick > 5)
            {
                go = null;
                StartCoroutine(Timer(2));
            }
        }
    }
    IEnumerator Timer(int updown)
    {
        if (updown == 1)
        {
            yield return new WaitForSeconds(Random.Range(1,10));
            tick = 0;
            go = "down";
        }
        if(updown == 2)
        {
            yield return new WaitForSeconds(Random.Range(1,4));
            tick = 0;
            go = "up";
        }
        }
   
}
