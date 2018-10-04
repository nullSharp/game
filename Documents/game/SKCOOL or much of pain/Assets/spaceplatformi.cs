using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceplatformi : MonoBehaviour {
    public Vector2 direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(direction == new Vector2(0,-1))
            {
                collision.rigidbody.AddForce(Vector2.down * 60, ForceMode2D.Impulse);
            }
            if (direction == new Vector2(0, 1))
            {
                collision.rigidbody.AddForce(Vector2.up * 60, ForceMode2D.Impulse);
            }
            if (direction == new Vector2(1, 0))
            {
                collision.rigidbody.AddForce(Vector2.right * 60, ForceMode2D.Impulse);
            }
            if (direction == new Vector2(-1, 0))
            {
                collision.rigidbody.AddForce(Vector2.left * 60, ForceMode2D.Impulse);
            }
        }
    }
}
