using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {
    private bool canShoot = true;
    // Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(canShoot)
        {
            StartCoroutine(Timer());
        }
	}
    IEnumerator Timer()
    {
        canShoot = false;
        yield return new WaitForSeconds(1.5f);
        canShoot = true;
    }
}
