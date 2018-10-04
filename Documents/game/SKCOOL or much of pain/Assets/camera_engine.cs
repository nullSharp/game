using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_engine : MonoBehaviour {
    public Camera c;
	// Use this for initialization
	void Start () {
        c = GetComponent<Camera>();
	}
	void OnSize(int size)
    {
        c.depth = size;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
