using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapka : MonoBehaviour {
    private bool canHeal = false;
    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("troll");
	}
	
	// Update is called once per frame
	void Update () {
		if(canHeal)
        {
            person.life += 0.0001f;
            gameObject.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canHeal = true;
            gameObject.transform.position = new Vector2(player.transform.position.x,player.transform.position.y + 0.5f);
        }
    }
}
