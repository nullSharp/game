using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeimaser : MonoBehaviour {
    public ObjectGameF f;
    private bool know = false;
    public Rigidbody2D rigidbody;
    public GameObject player;
    int direction;
    // Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (f.attack)
        { 
        if(player.transform.position.x > transform.position.x && know)
            {
                rigidbody.velocity = new Vector2(-2, 0);
            }
            if (player.transform.position.x < transform.position.x && know)
            {
                rigidbody.velocity = new Vector2(2, 0);
            }
        }
	}
}
