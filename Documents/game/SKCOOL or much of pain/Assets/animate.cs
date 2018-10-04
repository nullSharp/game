using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {
    private bool canShoot = false;
    // Use this for initialization
	void Start () {
        StartCoroutine(Starting());
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(canShoot)
        {
            StartCoroutine(Timer());
        }
	}
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(2);
        canShoot = true;
    }
    IEnumerator Timer()
    {
        canShoot = false;
        yield return new WaitForSeconds(1.5f);
        canShoot = true;
    }
}
