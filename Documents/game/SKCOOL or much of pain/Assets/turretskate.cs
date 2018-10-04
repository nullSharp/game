using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretskate : MonoBehaviour {
    public GameObject spike_sphere;
    private bool c = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(c)
        {
            StartCoroutine(sp());
        }
	}
    IEnumerator sp()
    {
        c = false;
        Instantiate(spike_sphere, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(10);
        c = true;
    }
}
