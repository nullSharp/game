using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elecball : MonoBehaviour {
    private Rigidbody2D ri;
    // Use this for initialization
    void Start()
    {
        ri = GetComponent<Rigidbody2D>();
        int f = Random.Range(1, 3);
        if (f == 1)
        {
            ri.AddForce(Vector2.right * 10, ForceMode2D.Impulse);
        }
        else
        {
            ri.AddForce(Vector2.left * 10, ForceMode2D.Impulse);
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != null)
        {
            Destroy(gameObject);
        }
    }
}
