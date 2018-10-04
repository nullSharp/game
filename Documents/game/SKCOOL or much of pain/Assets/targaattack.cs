using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targaattack : MonoBehaviour {
    private float rotate = 1;
    private int tick = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tick++;
        rotate += 0.1f;
        transform.Rotate(0, 0, rotate);
        if(tick > 200)
        {
            Destroy(gameObject);
        }
    }
}
