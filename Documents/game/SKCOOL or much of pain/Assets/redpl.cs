using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redpl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(-3 * Time.deltaTime, 0, 0);
	}
}
