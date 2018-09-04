using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(-2 * Time.fixedDeltaTime, 0, 0);
        transform.Translate(2 * Time.fixedDeltaTime, 0, 0);
	}
}
