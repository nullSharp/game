using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcanhot : MonoBehaviour {
    public int hot = 0;
    private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(hot > 3)
        {
            sprite.color = Color.red;
            gameObject.tag = "minuslife";
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "electric")
        {
            hot++;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "electric")
        {
            hot++;
        }
    }
}
