using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
    public Rigidbody2D platform;
    private bool Found;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
      
    }
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag=="Player" && person.life > 0)
        {
            platform.gravityScale = 2;
            platform.tag = "Death";
        }
    if(collision.gameObject.tag != "Player" || collision.gameObject.tag == null)
        {
            platform.gravityScale = -20f;
        }
                }
    
}
