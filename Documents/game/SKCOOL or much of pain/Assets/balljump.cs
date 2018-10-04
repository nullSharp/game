using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balljump : MonoBehaviour {
    public Rigidbody2D rigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="down")
        {
            rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }
}
