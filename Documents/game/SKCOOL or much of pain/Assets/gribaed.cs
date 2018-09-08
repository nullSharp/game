using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gribaed : MonoBehaviour {
    private int rad = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 1 * rad);
        rad++;
	}
}
