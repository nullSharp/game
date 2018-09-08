using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youdied : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(0.11f, -8.9f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(1.2625f, 1.437028f, 1);
	}
}
