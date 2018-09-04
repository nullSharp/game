using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour {
    private bool can = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(can)
        {
            StartCoroutine(Timer());
        }
	}
    IEnumerator Timer()
    {
        can = false;
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
