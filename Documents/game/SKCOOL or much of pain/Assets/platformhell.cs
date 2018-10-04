using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformhell : MonoBehaviour {
    private bool canMove = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(0, 0, 2 * Time.fixedDeltaTime);	
	}
   
}
