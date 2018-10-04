using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
	// Use this for initialization
	void Start () {
        StartCoroutine(TI());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator TI()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
