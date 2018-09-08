using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
    public GameObject bomb;
    public GameObject parent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(20 * Time.fixedDeltaTime, 0, 0);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            Instantiate(bomb, transform.position, Quaternion.identity);
            transform.position = parent.transform.position;
        }
    }
}
