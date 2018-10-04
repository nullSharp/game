using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterphysics : MonoBehaviour {
    [SerializeField] private CircleCollider2D water_id;
    [SerializeField] private Rigidbody2D rigidbody;
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
            water_id.isTrigger = true;
            rigidbody.gravityScale = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            water_id.isTrigger = false;
        }
    }
}
