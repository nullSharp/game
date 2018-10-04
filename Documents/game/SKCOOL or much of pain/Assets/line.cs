using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {
    public int d;
	// Use this for initialization
	void Start () {
        d = Random.Range(1, 5);
	}
	
	// Update is called once per frame
	void Update () {
		if(d == 1)
        {
            transform.Translate(1, 1, 0);
        }
        if(d == 2)
        {
            transform.Translate(-1, -1, 0);

        }
        if(d == 3)
        {
            transform.Translate(1, -1,0);
        }
        if(d == 4)
        {
            transform.Translate(-1, 1,0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != null)
        {
            Destroy(gameObject);
        }
    }
}
